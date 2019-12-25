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
    public partial class addquestions : System.Web.UI.Page
    {
        OleDbConnection conn = new OleDbConnection();
        DataSet ds;
        OleDbDataAdapter adapter;
        OleDbDataReader Dreader;
        bool konuvar;
        protected void Page_Load(object sender, EventArgs e)
        {
            String baglanti = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/csharpsorucevap.accdb";
            conn.ConnectionString = baglanti;
            hiddenogretmen.Text = Session["ogretmenadi"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (konuadi.Text == "")
            {
                Response.Write("<script>alert('konu giriniz')</script>");
            }
            else { 

            string ara = "select konu from sorular where [konu] = '" + konuadi.Text + "'";
            OleDbCommand konuara = new OleDbCommand(ara, conn);
            conn.Open();

            OleDbDataReader aramayap = konuara.ExecuteReader();
            while (aramayap.Read())
            {
                if (aramayap.HasRows == true)
                {

                    konuvar = true;

                }
            }
            if (konuvar == true)
            {
                Response.Write("<script>alert('Konu adı daha önce kullanılmıştır.')</script>");
                konuvar = false;
            }
            if (aramayap.HasRows == false)
            {

                Response.Write("<script>alert('Kullanıcı Adı veya Şifre Yanlış')</script>");






                if (soru1.Text.Length > 0 && dogru1.Text.Length > 0 && yanliscevapbir1.Text.Length > 0 && yanliscevapiki1.Text.Length > 0 && yanliscevapuc1.Text.Length > 0)
                {
                    String soruekle1 = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)";
                    OleDbCommand cmd = new OleDbCommand(soruekle1, conn);
                    cmd.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text);
                    cmd.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue);
                    cmd.Parameters.AddWithValue("@konuadi", konuadi.Text);
                    cmd.Parameters.AddWithValue("@soru", soru1.Text);
                    cmd.Parameters.AddWithValue("@dogrucevap", dogru1.Text);
                    cmd.Parameters.AddWithValue("@yanlis1", yanliscevapbir1.Text);
                    cmd.Parameters.AddWithValue("@yanlis2", yanliscevapiki1.Text);
                    cmd.Parameters.AddWithValue("@yanlis3", yanliscevapuc1.Text);
                    cmd.ExecuteNonQuery();
                }

                if (soru2.Text.Length > 0 && dogru2.Text.Length > 0 && yanliscevapbir2.Text.Length > 0 && yanliscevapiki2.Text.Length > 0 && yanliscevapuc2.Text.Length > 0)
                {
                    String soruekle2 = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)";
                    OleDbCommand cmd2 = new OleDbCommand(soruekle2, conn);
                    cmd2.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text);
                    cmd2.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue);
                    cmd2.Parameters.AddWithValue("@konuadi", konuadi.Text);
                    cmd2.Parameters.AddWithValue("@soru", soru2.Text);
                    cmd2.Parameters.AddWithValue("@dogrucevap", dogru2.Text);
                    cmd2.Parameters.AddWithValue("@yanlis1", yanliscevapbir2.Text);
                    cmd2.Parameters.AddWithValue("@yanlis2", yanliscevapiki2.Text);
                    cmd2.Parameters.AddWithValue("@yanlis3", yanliscevapuc2.Text);
                    cmd2.ExecuteNonQuery();
                }

                if (soru3.Text.Length > 0 && dogru3.Text.Length > 0 && yanliscevapbir3.Text.Length > 0 && yanliscevapiki3.Text.Length > 0 && yanliscevapuc3.Text.Length > 0)
                {
                    String soruekle3 = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)";
                    OleDbCommand cmd3 = new OleDbCommand(soruekle3, conn);
                    cmd3.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text);
                    cmd3.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue);
                    cmd3.Parameters.AddWithValue("@konuadi", konuadi.Text);
                    cmd3.Parameters.AddWithValue("@soru", soru3.Text);
                    cmd3.Parameters.AddWithValue("@dogrucevap", dogru3.Text);
                    cmd3.Parameters.AddWithValue("@yanlis1", yanliscevapbir3.Text);
                    cmd3.Parameters.AddWithValue("@yanlis2", yanliscevapiki3.Text);
                    cmd3.Parameters.AddWithValue("@yanlis3", yanliscevapuc3.Text);
                    cmd3.ExecuteNonQuery();
                }

                if (soru4.Text.Length > 0 && dogru4.Text.Length > 0 && yanliscevapbir4.Text.Length > 0 && yanliscevapiki4.Text.Length > 0 && yanliscevapuc4.Text.Length > 0)
                {
                    String soruekle4 = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)";
                    OleDbCommand cmd4 = new OleDbCommand(soruekle4, conn);
                    cmd4.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text);
                    cmd4.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue);
                    cmd4.Parameters.AddWithValue("@konuadi", konuadi.Text);
                    cmd4.Parameters.AddWithValue("@soru", soru4.Text);
                    cmd4.Parameters.AddWithValue("@dogrucevap", dogru4.Text);
                    cmd4.Parameters.AddWithValue("@yanlis1", yanliscevapbir4.Text);
                    cmd4.Parameters.AddWithValue("@yanlis2", yanliscevapiki4.Text);
                    cmd4.Parameters.AddWithValue("@yanlis3", yanliscevapuc4.Text);
                    cmd4.ExecuteNonQuery();
                }



                if (soru5.Text.Length > 0 && dogru5.Text.Length > 0 && yanliscevapbir5.Text.Length > 0 && yanliscevapiki5.Text.Length > 0 && yanliscevapuc5.Text.Length > 0)
                {
                    String soruekle5 = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)";
                    OleDbCommand cmd5 = new OleDbCommand(soruekle5, conn);
                    cmd5.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text);
                    cmd5.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue);
                    cmd5.Parameters.AddWithValue("@konuadi", konuadi.Text);
                    cmd5.Parameters.AddWithValue("@soru", soru3.Text);
                    cmd5.Parameters.AddWithValue("@dogrucevap", dogru5.Text);
                    cmd5.Parameters.AddWithValue("@yanlis1", yanliscevapbir5.Text);
                    cmd5.Parameters.AddWithValue("@yanlis2", yanliscevapiki5.Text);
                    cmd5.Parameters.AddWithValue("@yanlis3", yanliscevapuc5.Text);
                    cmd5.ExecuteNonQuery();
                }

                if (soru6.Text.Length > 0 && dogru6.Text.Length > 0 && yanliscevapbir6.Text.Length > 0 && yanliscevapiki6.Text.Length > 0 && yanliscevapuc6.Text.Length > 0)
                {
                    String soruekle6 = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)";
                    OleDbCommand cmd6 = new OleDbCommand(soruekle6, conn);
                    cmd6.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text);
                    cmd6.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue);
                    cmd6.Parameters.AddWithValue("@konuadi", konuadi.Text);
                    cmd6.Parameters.AddWithValue("@soru", soru6.Text);
                    cmd6.Parameters.AddWithValue("@dogrucevap", dogru6.Text);
                    cmd6.Parameters.AddWithValue("@yanlis1", yanliscevapbir6.Text);
                    cmd6.Parameters.AddWithValue("@yanlis2", yanliscevapiki6.Text);
                    cmd6.Parameters.AddWithValue("@yanlis3", yanliscevapuc6.Text);
                    cmd6.ExecuteNonQuery();
                }

                if (soru7.Text.Length > 0 && dogru7.Text.Length > 0 && yanliscevapbir7.Text.Length > 0 && yanliscevapiki7.Text.Length > 0 && yanliscevapuc7.Text.Length > 0)
                {
                    String soruekle7 = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)";
                    OleDbCommand cmd7 = new OleDbCommand(soruekle7, conn);
                    cmd7.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text);
                    cmd7.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue);
                    cmd7.Parameters.AddWithValue("@konuadi", konuadi.Text);
                    cmd7.Parameters.AddWithValue("@soru", soru7.Text);
                    cmd7.Parameters.AddWithValue("@dogrucevap", dogru7.Text);
                    cmd7.Parameters.AddWithValue("@yanlis1", yanliscevapbir7.Text);
                    cmd7.Parameters.AddWithValue("@yanlis2", yanliscevapiki7.Text);
                    cmd7.Parameters.AddWithValue("@yanlis3", yanliscevapuc7.Text);
                    cmd7.ExecuteNonQuery();
                }

                if (soru8.Text.Length > 0 && dogru8.Text.Length > 0 && yanliscevapbir8.Text.Length > 0 && yanliscevapiki8.Text.Length > 0 && yanliscevapuc8.Text.Length > 0)
                {
                    String soruekle8 = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)";
                    OleDbCommand cmd8 = new OleDbCommand(soruekle8, conn);
                    cmd8.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text);
                    cmd8.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue);
                    cmd8.Parameters.AddWithValue("@konuadi", konuadi.Text);
                    cmd8.Parameters.AddWithValue("@soru", soru8.Text);
                    cmd8.Parameters.AddWithValue("@dogrucevap", dogru8.Text);
                    cmd8.Parameters.AddWithValue("@yanlis1", yanliscevapbir8.Text);
                    cmd8.Parameters.AddWithValue("@yanlis2", yanliscevapiki8.Text);
                    cmd8.Parameters.AddWithValue("@yanlis3", yanliscevapuc8.Text);
                    cmd8.ExecuteNonQuery();
                }

                if (soru9.Text.Length > 0 && dogru9.Text.Length > 0 && yanliscevapbir9.Text.Length > 0 && yanliscevapiki9.Text.Length > 0 && yanliscevapuc9.Text.Length > 0)
                {
                    String soruekle9 = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)";
                    OleDbCommand cmd9 = new OleDbCommand(soruekle9, conn);
                    cmd9.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text);
                    cmd9.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue);
                    cmd9.Parameters.AddWithValue("@konuadi", konuadi.Text);
                    cmd9.Parameters.AddWithValue("@soru", soru9.Text);
                    cmd9.Parameters.AddWithValue("@dogrucevap", dogru9.Text);
                    cmd9.Parameters.AddWithValue("@yanlis1", yanliscevapbir9.Text);
                    cmd9.Parameters.AddWithValue("@yanlis2", yanliscevapiki9.Text);
                    cmd9.Parameters.AddWithValue("@yanlis3", yanliscevapuc9.Text);
                    cmd9.ExecuteNonQuery();
                }

                if (soru10.Text.Length > 0 && dogru10.Text.Length > 0 && yanliscevapbir10.Text.Length > 0 && yanliscevapiki10.Text.Length > 0 && yanliscevapuc10.Text.Length > 0)
                {
                    String soruekle10 = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)";
                    OleDbCommand cmd10 = new OleDbCommand(soruekle10, conn);
                    cmd10.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text);
                    cmd10.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue);
                    cmd10.Parameters.AddWithValue("@konuadi", konuadi.Text);
                    cmd10.Parameters.AddWithValue("@soru", soru10.Text);
                    cmd10.Parameters.AddWithValue("@dogrucevap", dogru10.Text);
                    cmd10.Parameters.AddWithValue("@yanlis1", yanliscevapbir10.Text);
                    cmd10.Parameters.AddWithValue("@yanlis2", yanliscevapiki10.Text);
                    cmd10.Parameters.AddWithValue("@yanlis3", yanliscevapuc10.Text);
                    cmd10.ExecuteNonQuery();
                }
                conn.Close();

                Response.Write("<script> alert=('sorularınız eklenmiştir')</script>");
                Response.Redirect("welcome.aspx");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("welcome.aspx");
        }
    }
}