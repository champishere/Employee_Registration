using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Razin.Bo;

namespace Razin.Dal
{
    public class Dataacess
    {
        public static void AddEmployeeDetails(BaseEmployee employeeBizObj)
        {
            if (employeeBizObj == null)
            {
                throw new ArgumentNullException("employeeBizObj");
            }

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["EmpConString"].ConnectionString))
                {

                    using (var cmd =
                        new SqlCommand("spSaveEmployee",
                            con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmployeeName", employeeBizObj.FirstName);
                        cmd.Parameters.AddWithValue("@EmployeeAddress", employeeBizObj.Address);
                        cmd.Parameters.AddWithValue("@EmailId", employeeBizObj.EmailId);
                        cmd.Parameters.AddWithValue("@MobileNumber", employeeBizObj.MobileNumber);
                        cmd.Parameters.AddWithValue("@Designation", employeeBizObj.Designation);
                        cmd.Parameters.AddWithValue("@BaseSalary", employeeBizObj.Basesalary);
                        cmd.Parameters.AddWithValue("@Emptype", employeeBizObj.Emptype);
                        cmd.Parameters.AddWithValue("@Month", employeeBizObj.MonthlySalary);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        // int affectedRows = cmd.ExecuteNonQuery();

                        //return affectedRows == 1;
                    }
                }

            }
            catch (Exception ex)
            {
                
                throw;
            }
            
        }
        //private void Page_Error(object sender, EventArgs e)
        //{
        //    var exc = Server.GetLastError();


        //    if (exc.GetType() == typeof(InvalidOperationException))
        //    {

        //        Server.Transfer("Exception.aspx");
        //    }


        //    Response.Redirect("HttpErrorPage.aspx");


        //    Server.ClearError();
        //}

    }
}
