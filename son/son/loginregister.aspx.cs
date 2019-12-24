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
        OleDbCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

            String baglanti = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/csharpsorucevap.accdb";
            conn.ConnectionString = baglanti;
        }


        protected void girisyap_Click(object sender, EventArgs e)
        {
            if (giriskadi.Text == "" || girissifre.Text == "")
            {
                Response.Write("<script>alert('Giriş Yapmak için boş bilgi girmeyiniz.')</script>");
            }
            string komut = "select* from tablo1 where[ogretmenadi] = '" + giriskadi.Text + "' and[sifre] = '" + girissifre.Text + "'";
            OleDbCommand cmd = new OleDbCommand(komut, conn);
            conn.Open();

            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    Session["ogretmenadi"] = giriskadi.Text;
                    Response.Write("<script>alert('Giriş Başarılı Yönlendiriliyorsunuz.')</script>");
                    Response.Redirect("welcome.aspx");
                }
            }
            if (dr.HasRows == false)
            {

                Response.Write("<script>alert('Kullanıcı Adı veya Şifre Yanlış')</script>");
            }
            conn.Close();
        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (kayitograd.Text == "" || kayitogrbrans.Text == "" || kayitogrsifre.Text == "")
            {
                Response.Write("<script>alert('Herhangi bir bilgi boş olamaz.')</script>");
            }
            else { 

            cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "insert into tablo1 (ogretmenadi,okuladi,brans,sifre) values ('" + kayitograd.Text + "','" + DropDownListokul.SelectedValue + "','" + kayitogrbrans.Text + "','" + kayitogrsifre.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            RadioButton1.Checked = true;
            Response.Write("<script>alert('Kayıt Başarılı')</script>");
            }
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}