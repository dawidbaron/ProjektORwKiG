using BP.Helpers;
using BP.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BP.Services.User
{

    public class UserService:IUserService
    {
        private readonly DbContext _dbContext;
        public UserService(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Models.User.User Authenticate(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || (string.IsNullOrEmpty(password)))
            {
                return null;
            }
            var user = _dbContext.Set<Models.User.User>().SingleOrDefault(x => x.Email == email);

            if (user == null)
            {
                return null;
            }

            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                {
                    return null;
                }

            return user;
        }

        public Models.User.User Register(Models.User.User user, string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ApplicationException("Hasło jest wymagane!");
            }

            if (!IsValidEmail(user.Email))
            {
                throw new ApplicationException("Wpisz poprawny adres e-mail!");
            }

            if (_dbContext.Set<Models.User.User>().Any(x => x.Email == user.Email))
            {
                throw new ApplicationException("Użytkownik z adresem e-mail " + user.Email + " już istnieje ");
            }
            if (_dbContext.Set<Models.User.User>().Any(x => x.UserId == user.UserId))
            {
                user.UserId = Guid.NewGuid();
            }
            byte[] passwordHash, passwordSalt;

            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            _dbContext.Set<Models.User.User>().Add(user);
            _dbContext.SaveChanges();

            return user;
        }
        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Hasło nie może być puste.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Hasło nie może być puste.", "password");
            if (storedHash.Length != 64) throw new ArgumentException("Błędna długość zahashowanego hasło (64 bytes).", "passwordHash");
            if (storedSalt.Length != 128) throw new ArgumentException("Błędna długość odhashowanego hasło (128 bytes).", "passwordHash");

            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }

            return true;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public List<ReservationVM> GetUserReservations(Guid userId)
        {
            var reservations = (from r in _dbContext.Set<Models.ReservationPayment.Reservation>()
                                join f in _dbContext.Set<Models.Fields.Field>() on r.FieldId equals f.FieldId
                                where r.UserId == userId
                                select new ReservationVM
                                {
                                    ReservationId = r.ReservationId,
                                    Name = r.Title,
                                    Start = r.Start,
                                    End = r.End,
                                    Title = r.Title,
                                    Status = r.Status,
                                    TotalPrice = r.TotalPrice,
                                    FieldName = f.FieldName,
                                    City = f.City,
                                    Address = f.Address,
                                    Description = f.Description,
                                    PathUrl=f.PathUrl,
                                    ImgUrl=f.ImgUrl,
                                    Payable=f.Payable
                                }).ToList();

            return reservations;
        }
    }
}
