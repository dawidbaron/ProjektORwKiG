using BP.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BP.Services.User
{
    public interface IUserService
    {
        Models.User.User Authenticate(string email, string password);
        Models.User.User Register(Models.User.User email, string password);
        List<ReservationVM> GetUserReservations(Guid userId);
    }
}
