using System;
using System.Collections.Generic;
using MyEntityFrameworkLibrary.Classes;
using MyEntityFrameworkLibrary.Models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customers> list = CustomerOperations.CustomersWithContact();

            foreach (var customer in list)
            {
                Console.WriteLine(customer);
            }

            Console.ReadLine();
        }
    }
}
