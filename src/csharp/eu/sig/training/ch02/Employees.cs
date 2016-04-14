using System;

namespace eu.sig.training.ch02
{
    public static class Employees
    {
        // tag::printDepartmentEmployees[]
        public static void PrintDepartmentEmployees(string department)
        {
            Query q = new Query();
            foreach (Employee e in q.AddColumn("FamilyName")
                .AddColumn("Initials")
                .AddColumn("GivenName")
                .AddColumn("AddressLine1")
                .AddColumn("ZIPcode")
                .AddColumn("City")
                .AddTable("EMPLOYEES")
                .AddWhere($"EmployeeDep='{department}'")
                .Execute())
            {
                Console.WriteLine($@"<div name='addressDiv'>
                    {e.FamilyName}, {e.Initials}<br />" +
                    "{e.AddressLine1}<br />{e.ZipCode}{e.City}</div>");
            }
        }
        // end::printDepartmentEmployees[]
    }

    class Query
    {

        public Query AddColumn(string s)
        {
            return null;
        }

        public Employee[] Execute()
        {
            return null;
        }

        public Query AddWhere(string s)
        {
            return null;
        }

        public Query AddTable(string s)
        {
            return null;
        }
    }

    class Employee
    {

        public string FamilyName { get; set; }

        public string AddressLine1 { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public string Initials { get; set; }
    }
}
