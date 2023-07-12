using System;


namespace Expense
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            Db.setName(name);
            Response.Redirect("home.aspx");
        }

       
        public class LoginModel
        {
            public string Name { get; set; }
        }
    }
}