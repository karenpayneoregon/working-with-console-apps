/*
 * Top level style, this is okay as there is only one code set here
 */

using System;
using System.Collections.Generic;
using ContainerLibrary.Classes;
using DataLibrary.Classes;
using Spectre.Console;


Table table = new Table()
    .AddColumn("[yellow]Id[/]")
    .AddColumn("[yellow]Company[/]")
    .AddColumn("[yellow]Title[/]")
    .AddColumn("[yellow]First[/]")
    .AddColumn("[yellow]Last[/]")
    .Caption("[white]Customer data[/]")
    .Title("[white]Customer data[/]");

table.Columns[0].Alignment(Justify.Right);


List<CustomerEntity> customerEntities = Operations.ReadCustomers();

foreach (var customerEntity in customerEntities)
{
    table.AddRow(
        customerEntity.CustomerIdentifier.ToString(), 
        customerEntity.CompanyName, 
        customerEntity.ContactTitle, 
        customerEntity.FirstName, 
        customerEntity.LastName);
}

AnsiConsole.Write(table);
Console.ReadLine();

