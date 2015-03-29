using System;
using Razin.Bll;
using Razin.Bo;
using System.Windows.Forms;
using Razin.Web.Service;


namespace Razin.Web
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            //File.SetCreationTime(@"C:\Users\rbharde\Desktop\4-Web.config", DateTime.Now);

            if (ddl_emptype.SelectedIndex == 0)
            {
                Response.Write("<script>alert('Please Select Valid Employee Type');</script>");
            }

            else
            {

                BaseEmployee employee;

                switch (ddl_emptype.SelectedValue.ToLowerInvariant())
                {
                    case "full-time":
                        employee = new FulltimeEmployee();
                      //  employee.MonthlySalary = employee.Monthlysalary;
                        break;
                    case "part-time":
                        employee = new ParttimeEmployee();
                      //  employee.MonthlySalary = employee.Monthlysalary;
                        break;

                    default:
                        throw new InvalidOperationException("Could not recognise the provided employee type");
                }

                employee.FirstName = txtname.Text;
                employee.Address = txAddress.Text;
                employee.EmailId = txtEmailid.Text;
                employee.MobileNumber = txtmobile.Text;
                employee.Designation = txtdesignation.Text;
                employee.Basesalary = Convert.ToSingle(txtsalary.Text);
                employee.Emptype = ddl_emptype.SelectedValue;
                employee.MonthlySalary = employee.Monthlysalary;
               var client = new RazinServiceClient();
                // Storing in DB
               // RegistrationBl.SaveUserregisrationBl(employee);
                client.SaveEmployee(employee);
               // MessageBox.Show("Data inserted successfully!!!");
                Response.Redirect("~/Registration.aspx");

            }
        }

        private void Page_Error(object sender, EventArgs e)
        {
            var exc = Server.GetLastError();


            if (exc.GetType() == typeof(InvalidOperationException))
            {

                Server.Transfer("~/Exception.aspx");
            }


            Response.Redirect("~/HttpErrorPage.aspx");

            
            Server.ClearError();
        }
    }
    }

