using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyEntityFrameworkLibrary.Data;
using MyEntityFrameworkLibrary.Models;

namespace MyEntityFrameworkLibrary.Classes
{
    public class CustomerOperations
    {
        public static List<Customers> CustomersWithContact()
        {
            using var context = new NorthwindContext();
            return context
                .Customers
                .Include(customer => customer.Contact)
                .Where(customer => customer.CountryIdentifier == 8)
                .ToList();
        }
    }
}
