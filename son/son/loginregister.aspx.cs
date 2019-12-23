using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

namespace son
{
    public partial class giriskayitt : System.Web.UI.Page
    {
        OleDbConnection conn = new OleDbConnection();
        DataSet ds;
        OleDbDataAdapter adapter;
        OleDbCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

            String baglanti = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/csharpsorucevap.accdb";
            conn.ConnectionString = baglanti;
        }


        protected void girisyap_Click(object sender, EventArgs e)
        {
            string komut = "select* from tablo1 where[ogretmenadi] = '" + giriskadi.Text + "' and[sifre] = '" + girissifre.Text + "'";
            OleDbCommand cmd = new OleDbCommand(komut, conn);
            conn.Open();

            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    Response.Write("Giriş Başarılı");
                    Response.Redirect("welcome.aspx");
                }
            }
            if (dr.HasRows == false)
            {

                Response.Write("kullanıcı Adı veya Şifre yanlış.");
            }
            conn.Close();
        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "insert into tablo1 (ogretmenadi,okuladi,brans,sifre) values ('" + kayitograd.Text + "','" + DropDownListokul.SelectedValue + "','" + kayitogrbrans.Text + "','" + kayitogrsifre.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}