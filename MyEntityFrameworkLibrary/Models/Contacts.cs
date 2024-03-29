﻿
#nullable disable
using System.Collections.Generic;

namespace MyEntityFrameworkLibrary.Models
{
    public partial class Contacts
    {
        public Contacts()
        {
            ContactDevices = new HashSet<ContactDevices>();
            Customers = new HashSet<Customers>();
        }

        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? ContactTypeIdentifier { get; set; }

        public virtual ContactType ContactTypeIdentifierNavigation { get; set; }
        public virtual ICollection<ContactDevices> ContactDevices { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
    }
}