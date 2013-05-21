using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Server=YASSIR-PC\PIXO;database=Eljadida;integrated security=true");
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["password"] != null && Request.Cookies["nom"] != null)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM membre WHERE pseudo=@pseudo and mot_de_passe=@password", con);
            cmd.Parameters.Add(new SqlParameter("@pseudo", Request.Cookies["nom"].Value));
            cmd.Parameters.Add(new SqlParameter("@password", Request.Cookies["password"].Value));
            con.Open();
             SqlDataReader r = cmd.ExecuteReader();
             if (r.Read())
             {
                 con.Close();
                 Response.Redirect("connecter.aspx");
             }
             con.Close();
        }

    }
    protected void btn_connecter_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM membre WHERE pseudo=@pseudo and mot_de_passe=@password", con);
        cmd.Parameters.Add(new SqlParameter("@pseudo", txt_nom.Text));
        cmd.Parameters.Add(new SqlParameter("@password", txt_password.Text));
        con.Open();
        SqlDataReader r = cmd.ExecuteReader();
        if (r.Read())
        {
           
            if (check_cookie.Checked)
            {
                Response.Cookies["password"].Value = txt_password.Text;
                Response.Cookies["nom"].Value = txt_nom.Text;
                Response.Cookies["password"].Expires = DateTime.Now.AddMinutes(1);
                Response.Cookies["nom"].Expires = DateTime.Now.AddMinutes(1);
            }
            Response.Redirect("connecter.aspx");
            con.Close();
           
        }
        else
        {
            Response.Write("<h1> Erreur de connection verfier votre mot de passe et pseudo</h1>");
        }
        con.Close();

        

           


    }
}
