using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BP.Models.ViewModels
{
    public class FieldVM
    {
        public Guid FieldId { get; set; }
        public string Name { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string PathUrl { get; set; }
        public string ImgUrl { get; set; }
        public double PriceHour { get; set; }
        public int DefaultPlayerLimit { get; set; }
        public bool Payable { get; set; }

        public string FieldContactName { get; set; }
        public string FieldContactEmail { get; set; }
        public string FieldContactPhoneNumber { get; set; }

        public string FieldTypeName { get; set; }

        public string SportTypeNames { get; set; }
        public string Dimensions { get; set; }

}
}
