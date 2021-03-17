using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTO_s
{
    public class RentalDetailDto : IDto
    {
        public string CarName { get; set; }
        public string CompanyName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
