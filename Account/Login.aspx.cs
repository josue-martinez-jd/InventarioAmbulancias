using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Web;
using System.Web.UI;
using test2;

public partial class Account_Login : Page
{
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void LogIn(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // Validate the user password
                var manager = new UserManager();
                ApplicationUser user = manager.Find(txtUsuario.Text, txtContrasena.Text);
                if (user != null)
                {
                    IdentityHelper.SignIn(manager, user, chkRecordar.Checked);
                    IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                }
                else
                {
                    lblErrorInicioSesion.Text = "Usuario o contrasena invalido";
                }
            }
        }
}