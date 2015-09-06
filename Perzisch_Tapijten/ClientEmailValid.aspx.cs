using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Perzisch_Tapijten
{
    public partial class ClientEmailValid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "An email has been send to your email account.<br />" +
            "Please check your email, to activate your account.";

        }
    }
}