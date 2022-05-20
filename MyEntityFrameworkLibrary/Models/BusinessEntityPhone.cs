
#nullable disable
using System;

namespace MyEntityFrameworkLibrary.Models
{
    public partial class BusinessEntityPhone
    {
        public int BusinessEntityPhoneId { get; set; }
        public string PhoneNumber { get; set; }
        public int? PhoneNumberTypeId { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}