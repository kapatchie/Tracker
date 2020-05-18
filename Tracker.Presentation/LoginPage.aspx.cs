using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Objects.DataClasses;
using System.Data.Objects.SqlClient;



namespace Tracker.Presentation
{
    public partial class LoginPage : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if(Domain.UserManager.loggedIn(username, password))
            {
                resultLabel.Text = "Logged in";
                Response.Redirect("Faults.aspx");
            }
            else { resultLabel.Text = "Either the username or password is incorrect"; }
         }    
    }
}