using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Perzisch_Tapijten
{
    public partial class ClientRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Ok_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (Email.Text == Email1.Text && Password.Text == Password1.Text)
                {
                    EmailErr.Visible = false;
                    sql_object SqlObj = new sql_object();
                    string Gender = Male.Checked == true ? "M":"F";


                    SqlObj.ClientAdd(FirstName.Text, LastName.Text, Address.Text, Email.Text, Gender, Password.Text);
                    Response.Redirect("~/Default.aspx");
                }
                else if (Email.Text != Email1.Text)
                {
                    EmailErr.Text = "Emails are not the same.";
                    EmailErr.Visible = true;
                }
                else
                {
                    EmailErr.Text = "Passwords are not the same.";
                    EmailErr.Visible = true;
                }
            }

        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}