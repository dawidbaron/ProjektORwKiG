using BP.Services.Reservation;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BP.Controllers.Reservation
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        // GET: api/<ValuesController>
        public ReservationController(IReservationService reservationService)
        {
          _reservationService = reservationService;
        }
        //[HttpGet("[action]/{fieldId}")]
        //public IActionResult GetReservations(Guid fieldId)
        //{
        //    try
        //    {
        //        var reservations = _reservationService.GetReservationsByFieldId(fieldId);
        //        return Ok(reservations);
        //    }
        //    catch (ApplicationException ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        [HttpPost("[action]")]
        public IActionResult CreateReservation([FromBody] Models.ReservationPayment.Reservation reservation)
        {
            try
            {
                _reservationService.CreateReservation(reservation);
                return Ok();
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("[action]/{id}")]
        public IActionResult GetReservationById(int id)
        {
            try
            {
                var reservations = _reservationService.GetReservationById(id);
                return Ok(reservations);
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("[action]/{title}")]
        public IActionResult UpdateReservations(string title)
        {
            try
            {
                var reservations = _reservationService.SearchReservations(title);
                return Ok(reservations);
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("[action]/{reservationid}")]
        public async Task<ActionResult<Models.ReservationPayment.Reservation>> DeleteReservation(int reservationid)
        {
            try
            {

                var reservations = _reservationService.GetReservationById(reservationid);

                if (reservations == null)
                {
                    return NotFound($"Rezerwacja o podanym id nie istnieje");
                }

                return await _reservationService.DeleteReservation(reservationid);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error usuwania");
            }
        }
    }
}
