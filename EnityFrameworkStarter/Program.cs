using System;
using System.Linq;
using EntityFrameworkStarter.Classes;
using EntityFrameworkStarter.Data;
using Microsoft.EntityFrameworkCore;
using Spectre.Console;

namespace EntityFrameworkStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerOperations.ListWithContacts();
            AnsiConsole.Markup($"[white on cornflowerblue]Auto-close in [/][darkseagreen1_1 on cornflowerblue]{ConsoleHelpers.DefaultTimeOut}[/][white on cornflowerblue] seconds[/]");
            ConsoleHelpers.ReadLineAsStringTimeout();
        }
    }
}
