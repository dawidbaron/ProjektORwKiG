using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BP.Models.ViewModels
{
    public class ReservationVM
    {
        public int ReservationId { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Title { get; set; }
        public double TotalPrice { get; set; }
        public string Status { get; set; }
        public Guid FieldId { get; set; }
        public Guid UserId { get; set; }
        public string FieldName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string PathUrl { get; set; }
        public string ImgUrl { get; set; }
        public bool Payable { get; set; }


    }
}
