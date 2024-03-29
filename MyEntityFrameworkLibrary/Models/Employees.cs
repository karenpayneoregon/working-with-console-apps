﻿
#nullable disable
using System;
using System.Collections.Generic;

namespace MyEntityFrameworkLibrary.Models
{
    public partial class Employees
    {
        public Employees()
        {
            EmployeeTerritories = new HashSet<EmployeeTerritories>();
            InverseReportsToNavigation = new HashSet<Employees>();
            Orders = new HashSet<Orders>();
        }

        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int? ContactTypeIdentifier { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public int? CountryIdentifier { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }

        public virtual ContactType ContactTypeIdentifierNavigation { get; set; }
        public virtual Countries CountryIdentifierNavigation { get; set; }
        public virtual Employees ReportsToNavigation { get; set; }
        public virtual ICollection<EmployeeTerritories> EmployeeTerritories { get; set; }
        public virtual ICollection<Employees> InverseReportsToNavigation { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}