using BP.Helpers;
using BP.Models.ReservationPayment;
using BP.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BP.Services.Reservation
{
    public class ReservationService : IReservationService
    {
        private readonly DbContext _dbContext;
        public ReservationService(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateReservation(Models.ReservationPayment.Reservation reservation)
        {

            Models.ReservationPayment.Reservation reservationDTO = new Models.ReservationPayment.Reservation();
            DateTime dateS = reservation.Start.AddHours(2);
            DateTime dateK = reservation.End.AddHours(2);
            reservationDTO.ReservationId = reservation.ReservationId;
            reservationDTO.Start = dateS;
            reservationDTO.End = dateK;
            reservationDTO.Title = reservation.Title;
            reservationDTO.FieldId = reservation.FieldId;
            reservationDTO.TotalPrice = reservation.TotalPrice;
            reservationDTO.PrimaryColor = reservation.PrimaryColor;
            reservationDTO.SecondaryColor = reservation.SecondaryColor;
            reservationDTO.UserId = reservation.UserId;
            reservationDTO.Status = reservation.Status;
            _dbContext.Set<Models.ReservationPayment.Reservation>().Add(reservationDTO);
            _dbContext.SaveChanges();

            var reservationId = reservationDTO.ReservationId;

            DateTime paymentDate = DateTime.Now;

            Payment paymentDTO = new Payment();
            paymentDTO.ReservationId = reservationId;
            paymentDTO.PaymentId = Guid.NewGuid();
            paymentDTO.Total = reservation.TotalPrice;
            paymentDTO.FieldId = reservation.FieldId;
            paymentDTO.Date = paymentDate;

            _dbContext.Set<Payment>().Add(paymentDTO);
            _dbContext.SaveChanges();

            //// Get newly created paymentId
            //var paymentId = paymentDTO.PaymentId;

            //// Save receipt obj to DB
            //Receipt receipt = new Receipt();
            //receipt.PaymentId = (Guid)paymentId;
            //receipt.ReservationId = (Guid)reservationId;
            //receipt.FieldId = reservation.FieldId;
            //receipt.TotalPrice = reservation.TotalPrice;

            //_dbContext.Receipts.Add(receipt);
            //_dbContext.SaveChanges();
        }

        public async Task<Models.ReservationPayment.Reservation> DeleteReservation(int reservationid)
        {
            var result = await _dbContext.Set<Models.ReservationPayment.Reservation>()
                .FirstOrDefaultAsync(e => e.ReservationId == reservationid);
            if (result != null)
            {
                _dbContext.Set<Models.ReservationPayment.Reservation>().Remove(result);
                await _dbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public List<ReservationVM> GetReservationById(int id)
        {
            var reservation = (from r in _dbContext.Set<Models.ReservationPayment.Reservation>()
                               join f in _dbContext.Set<Models.Fields.Field>() on r.FieldId equals f.FieldId
                               where r.ReservationId == id
                               select new ReservationVM
                               {
                                   ReservationId = r.ReservationId,
                                   Title = r.Title,
                                   Start = r.Start,
                                   End = r.End,
                                   TotalPrice = r.TotalPrice,
                                   FieldName = f.FieldName,
                                   PathUrl = f.PathUrl,
                                   ImgUrl = f.ImgUrl,
                                   Description = f.Description,
                                   Address = f.Address
                               }).ToList();
            return reservation;
        }

        public List<Models.ReservationPayment.Reservation> GetReservationsByFieldId(Guid fieldId)
        {
            var reservations = (from r in _dbContext.Set<Models.ReservationPayment.Reservation>()
                                where r.FieldId == fieldId
                                select new Models.ReservationPayment.Reservation
                                {
                                    ReservationId = r.ReservationId,
                                    Title = r.Title,
                                    Start = r.Start,
                                    End = r.End,
                                    FieldId = r.FieldId,
                                    TotalPrice = r.TotalPrice,
                                    PrimaryColor = r.PrimaryColor,
                                    SecondaryColor = r.SecondaryColor,
                                    UserId = r.UserId,
                                    Status=r.Status
                                }).ToList();


            return reservations;
        }

        public List<Models.ReservationPayment.Reservation> SearchReservations(string title)
        {
            var reservations = (from r in _dbContext.Set<Models.ReservationPayment.Reservation>()
                                where r.Title.ToLower().Contains(title.ToLower())
                                select new Models.ReservationPayment.Reservation
                                {
                                    ReservationId = r.ReservationId,
                                    Title = r.Title,
                                    Start = r.Start,
                                    End = r.End,
                                    FieldId = r.FieldId,
                                    TotalPrice = r.TotalPrice,
                                    PrimaryColor=r.PrimaryColor,
                                    SecondaryColor=r.SecondaryColor,
                                    UserId = r.UserId,
                                    Status = r.Status
                                }).ToList();

            return reservations;
        }

        //public async Task CreateReservation(CreateReservationRequest request)
        //{
        //    //var reservationId = Guid.NewGuid();
        //    //await _context.Set<Models.ReservationPayment.Reservation>().AddAsync(
        //    //    Models.ReservationPayment.Reservation.Create(
        //    //        reservationId,
        //    //        request.FieldId,
        //    //        request.UserId,
        //    //        request.MatchId,
        //    //        request.PaymentId,
        //    //        request.ReservationPaymentId,
        //    //        request.ReservationStatusDictionaryId,
        //    //        request.ReservationMatchId,
        //    //        request.Title,
        //    //        request.Start,
        //    //        request.End,
        //    //        request.TotalPrice,
        //    //        request.StatusId

        //    //    ));
        //    //await _context.SaveChangesAsync();
        //    throw new NotImplementedException();
        //}

        //public Task DeleteReservation()
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task UpdateReservation(UpdateReservationRequest request)
        //{
        //    //var reservation = await _context.Set<Models.ReservationPayment.Reservation>().SingleOrDefaultAsync(x => x.ReservationId == request.ReservationId);
        //    //if (reservation is null)
        //    //{
        //    //    throw ReservationDoesNotExistException.Create(request.Id);
        //    //}
        //    //reservation.Update(
        //    //    request.FieldId,
        //    //    request.UserId,
        //    //    request.MatchId,
        //    //    request.PaymentId,
        //    //    request.ReservationPaymentId,
        //    //    request.ReservationStatusDictionaryId,
        //    //    request.ReservationMatchId,
        //    //    request.Title,
        //    //    request.Start,
        //    //    request.End,
        //    //    request.TotalPrice,
        //    //    request.StatusId
        //    //    );
        //    throw new NotImplementedException();
        //}
    }
}
