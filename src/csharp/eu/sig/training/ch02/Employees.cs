using System;

namespace eu.sig.training.ch02
{
	public static class Employees {
		// tag::printDepartmentEmployees[]
		public static void printDepartmentEmployees(string department) {
			Query q = new Query();
			foreach (Employee e in q.AddColumn("FamilyName")
				.AddColumn("Initials")
				.AddColumn("GivenName")
				.AddColumn("AddressLine1")
				.AddColumn("ZIPcode")
				.AddColumn("City")
				.AddTable("EMPLOYEES")
				.AddWhere("EmployeeDep='" + department + "'")
				.Execute()) {
				Console.WriteLine("<div name='addressDiv'" + e.getFamilyName()
					+ ", " + e.getInitials() + "<br />" + e.getAddressLine1()
					+ "<br />" + e.getZipCode() + e.getCity() + "</div>");
			}
		}
		// end::printDepartmentEmployees[]
	}

	class Query {

		public Query AddColumn(string s) {
			return null;
		}

		public Employee[] Execute() {
			return null;
		}

		public Query AddWhere(string s) {
			return null;
		}

		public Query AddTable(string s) {
			return null;
		}
	}

	class Employee {

		public string getFamilyName() {
			return null;
		}

		public string getAddressLine1() {
			return null;
		}

		public string getZipCode() {
			return null;
		}

		public string getCity() {
			return null;
		}

		public string getInitials() {
			return null;
		}
	}
}
