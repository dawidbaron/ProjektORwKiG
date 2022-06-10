using BP.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BP.Services.Reservation
{
    public interface IReservationService
    {
        List<Models.ReservationPayment.Reservation> GetReservationsByFieldId(Guid fieldId);
        void CreateReservation(Models.ReservationPayment.Reservation reservation);
        public Task<Models.ReservationPayment.Reservation> DeleteReservation(int reservationid);
        List<ReservationVM> GetReservationById(int id);
        List<Models.ReservationPayment.Reservation> SearchReservations(string title);
    }
}
