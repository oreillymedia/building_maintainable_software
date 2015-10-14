package eu.sig.training.ch02;

import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Properties;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class BalancesServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private Properties conf;

    @Override
    // tag::doGet[]
    public void doGet(HttpServletRequest req, HttpServletResponse resp)
        throws ServletException, IOException {
        resp.setContentType("application/json");
        try {
            Connection conn = DriverManager.
                getConnection(this.conf.getProperty("handler.jdbcurl"));
            ResultSet results =
                conn.createStatement()
                    .executeQuery(
                        "SELECT account, balance FROM ACCTS WHERE id="
                            + req.getParameter(conf.
                                getProperty("request.parametername")));
            float totalBalance = 0;
            resp.getWriter().print("{\"balances\":[");
            while (results.next()) {
                // Assuming result is 9-digit bank account number,
                // validate with 11-test:
                int sum = 0;
                for (int i = 0; i < results.getString("account")
                    .length(); i++) {
                    sum = sum + (9 - i)
                            * Character.getNumericValue(results.getString(
                            "account").charAt(i));
                }
                if (sum % 11 == 0) {
                    totalBalance += results.getFloat("balance");
                    resp.getWriter().print(
                        "{\"" + results.getString("account") + "\":"
                            + results.getFloat("balance") + "}");
                }
                if (results.isLast()) {
                    resp.getWriter().println("],");
                } else {
                    resp.getWriter().print(",");
                }
            }
            resp.getWriter().println("\"total\":" + totalBalance + "}");
        } catch (SQLException e) {
            System.out.println("SQL exception: " + e.getMessage());
        }
    }
    // end::doGet[]
}
