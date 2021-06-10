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
        private string labelText = "Alfredo";

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = labelText;
        }
        
        protected void btnLogin_click(object sender, EventArgs e)
        {
            
            DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            
            if(dv !=null)
            {
                string name = (string)dv.Table.Rows[0][1];
                string lastName = (string)dv.Table.Rows[0][3];
                int phone = (int)dv.Table.Rows[0][2];
                 
                userID.Text = "well";
                Label1.Text = "Datos: " + " " + name + " " + lastName + " " +phone.ToString();
            }
            else
            {
                userID.Text = "bad";
                Label1.Text = "No se pudo realizar la consulta =(";
            }


        }
    }
}