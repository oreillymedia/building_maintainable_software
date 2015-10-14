package eu.sig.training.ch02;

public class Employees {
    // tag::printDepartmentEmployees[]    
    public static void printDepartmentEmployees(String department) {
        Query q = new Query();
        for (Employee e : q.addColumn("FamilyName")
            .addColumn("Initials")
            .addColumn("GivenName")
            .addColumn("AddressLine1")
            .addColumn("ZIPcode")
            .addColumn("City")
            .addTable("EMPLOYEES")
            .addWhere("EmployeeDep='" + department + "'")
            .execute()) {
            System.out.println("<div name='addressDiv'" + e.getFamilyName()
                + ", " + e.getInitials() + "<br />" + e.getAddressLine1()
                + "<br />" + e.getZipCode() + e.getCity() + "</div>");
        }
    }
    // end::printDepartmentEmployees[]
}

class Query {

    @SuppressWarnings("unused")
    public Query addColumn(String string) {
        return null;
    }

    public Employee[] execute() {
        return null;
    }

    @SuppressWarnings("unused")
    public Query addWhere(String string) {
        return null;
    }

    @SuppressWarnings("unused")
    public Query addTable(String string) {
        return null;
    }
}

class Employee {

    public String getFamilyName() {
        return null;
    }

    public String getAddressLine1() {
        return null;
    }

    public String getZipCode() {
        return null;
    }

    public String getCity() {
        return null;
    }

    public String getInitials() {
        return null;
    }
}
