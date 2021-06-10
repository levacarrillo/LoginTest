using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginTest
{
    public partial class login : System.Web.UI.Page
    {
        private string labelText = "Write your first name as User";

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = labelText;
        }
        
        protected void btnLogin_click(object sender, EventArgs e)
        {
            
            DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            
            if(dv !=null && dv.Count>0)
            {
                string firstName = (string)dv.Table.Rows[0][1];
                string lastName = (string)dv.Table.Rows[0][2];
                int age = (int)dv.Table.Rows[0][3];
                int phone = (int)dv.Table.Rows[0][4];
                Label1.Text = "Acceso correcto, datos de usuario: " + firstName + " " + lastName + ", edad: " + age + ", teléfono: " + phone;
            }
            else
            {
                Label1.Text = "Usuario o contraseña inválidos :'(";
            }

            userID.Text = "";
        }
    }
}