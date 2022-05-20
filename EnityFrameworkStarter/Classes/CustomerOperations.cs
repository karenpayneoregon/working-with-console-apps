using System.Linq;
using EntityFrameworkStarter.Data;
using Microsoft.EntityFrameworkCore;
using Spectre.Console;

namespace EntityFrameworkStarter.Classes
{
    public class CustomerOperations
    {
        public static void ListWithContacts()
        {
            var table = new Table()
                .RoundedBorder()
                .AddColumn("[b]Id[/]")
                .AddColumn("[b]Name[/]")
                .AddColumn("[b]First[/]")
                .AddColumn("[b]Last[/]")
                .Alignment(Justify.Center)
                .BorderColor(Color.LightSlateGrey)
                .Title("[yellow]Customers[/]");

            table.Columns[0].Alignment(Justify.Right);

            using (var context = new NorthwindContext())
            {
                var customers = context
                    .Customers
                    .Include(customer => customer.Contact)
                    .Where(customer => customer.CountryIdentifier == 8)
                    .ToList();

                foreach (var customer in customers)
                {
                    table.AddRow(
                        customer.CustomerIdentifier.ToString(), 
                        customer.CompanyName, 
                        customer.Contact.FirstName, 
                        customer.Contact.LastName);
                }
            }

            AnsiConsole.Write(table);

        }
    }
}
