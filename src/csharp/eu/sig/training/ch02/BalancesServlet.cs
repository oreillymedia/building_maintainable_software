using System;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eu.sig.training.ch02
{
    public class BalancesServlet
    {
        // Visual Studio Code Analysis is right in pointing out that the following method has
        // security flaws. However, that's beside the point for this example.
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        // tag::doGet[]
        public void DoGet(HttpRequest req, HttpResponse resp)
        {
            resp.ContentType = "application/json";
            string command = "SELECT account, balance " +
                "FROM ACCTS WHERE id=" + req.Params[
                    ConfigurationManager.AppSettings["request.parametername"]];
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command,
                ConfigurationManager.AppSettings["handler.serverstring"]);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "ACCTS");
            DataTable dataTable = dataSet.Tables[0];
            try
            {
                float totalBalance = 0;
                int rowNum = 0;
                resp.Write("{\"balances\":[");
                while (dataTable.Rows.GetEnumerator().MoveNext())
                {
                    rowNum++;
                    DataRow results = (DataRow)dataTable.Rows.GetEnumerator().Current;
                    // Assuming result is 9-digit bank account number,
                    // validate with 11-test:
                    int sum = 0;
                    for (int i = 0; i < ((string)results["account"]).Length; i++)
                    {
                        sum = sum + (9 - i) *
                            (int)Char.GetNumericValue(((string)results["account"])[i]);
                    }
                    if (sum % 11 == 0)
                    {
                        totalBalance += (float)results["balance"];
                        resp.Write($"{{\"{results["account"]}\":{results["balance"]}}}");
                    }
                    if (rowNum == dataTable.Rows.Count)
                    {
                        resp.Write("],\n");
                    }
                    else
                    {
                        resp.Write(",");
                    }
                }
                resp.Write($"\"total\":{totalBalance}}}\n");
            }
            catch (SqlException e)
            {
                Console.WriteLine($"SQL exception: {e.Message}");
            }
        }
        // end::doGet[]
    }
}
