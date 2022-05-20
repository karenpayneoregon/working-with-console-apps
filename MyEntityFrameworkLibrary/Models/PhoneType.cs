
#nullable disable
using System.Collections.Generic;

namespace MyEntityFrameworkLibrary.Models
{
    public partial class PhoneType
    {
        public PhoneType()
        {
            ContactDevices = new HashSet<ContactDevices>();
        }

        public int PhoneTypeIdenitfier { get; set; }
        public string PhoneTypeDescription { get; set; }

        public virtual ICollection<ContactDevices> ContactDevices { get; set; }
    }
}