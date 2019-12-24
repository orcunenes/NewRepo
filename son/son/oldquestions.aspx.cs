using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.Diagnostics;
namespace son
{
    public partial class oldquestions : System.Web.UI.Page
    {
        OleDbConnection conn = new OleDbConnection();
        DataSet ds;
        OleDbDataAdapter adapter;
        OleDbCommand cmd,komut,sil;
        OleDbDataReader Dreader;
        TextBox textbox1 = new TextBox();
        TextBox textbox2 = new TextBox();
        TextBox textbox3 = new TextBox();
        TextBox textbox4 = new TextBox();
        TextBox textbox5 = new TextBox();
        protected void Page_Load(object sender, EventArgs e)
        {

            
            Label1.Text = Session["ogretmenadi"].ToString();

        String baglanti = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/csharpsorucevap.accdb";
            conn.ConnectionString = baglanti;
            conn.Open();

            String konularisec = ("select konu from sorular where ogretmen='"+Session["ogretmenadi"].ToString()+"'");
            OleDbCommand cmd = new OleDbCommand(konularisec, conn);
            Dreader = cmd.ExecuteReader();
            while(Dreader.Read())
                {
    
                if (DropDownList1.Items.FindByValue(Dreader[0].ToString()) == null)
                    {
                    DropDownList1.Items.Add(new ListItem(Dreader[0].ToString(), Dreader[0].ToString()));


                    }
                }
            conn.Close();
        }

        protected void giris_Click(object sender, EventArgs e)
        {
            conn.Open();
            String Sorularisec = ("select soru,dcevap,ycevap1,ycevap2,ycevap3 from sorular where ogretmen = '" + Label1.Text + "' and konu = '" + DropDownList1.SelectedValue + "'");
            OleDbCommand cmd = new OleDbCommand(Sorularisec, conn);
            OleDbDataReader Dreader = cmd.ExecuteReader();
            
            string[] oku = new string[10];
            int i;
            i = 0;

            while (Dreader.Read()) {
                textbox1 = new TextBox();
                
                textbox1.ID = "textbox" + i.ToString();
                textbox1.Text = Dreader[0].ToString();
                this.Panel1.Controls.Add(textbox1);



                /*
                 * textbox2 = new TextBox();
                textbox3 = new TextBox();
                textbox4 = new TextBox();
                textbox5 = new TextBox();  
                textbox2.ID = "dogrucevap" + i.ToString();
                textbox2.Text = Dreader[1].ToString();
                textbox3.ID = "yanlis1" + i.ToString();
                textbox3.Text = Dreader[2].ToString();
                textbox4.ID = "yanlis2" + i.ToString();
                textbox4.Text = Dreader[3].ToString();
                textbox5.ID = "yanlis3" + i.ToString();
                textbox5.Text = Dreader[4].ToString();

                
                this.Panel1.Controls.Add(textbox2);
                this.Panel1.Controls.Add(textbox3);
                this.Panel1.Controls.Add(textbox4);
                this.Panel1.Controls.Add(textbox5); */



                komut = new OleDbCommand();
                komut.Connection = conn;
                komut.CommandText = "insert into tablo2 (ogretmen,konu,soru) values ('" + Label1.Text + "','" + DropDownList1.SelectedValue + "','" + textbox1.Text + "')";
                komut.ExecuteNonQuery();




                i = i + 1;

            }



            Button5.Visible = true;
            Panel2.Visible = true;
            conn.Close();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            sil = new OleDbCommand();
            sil.Connection = conn;
            sil.CommandText = "Delete * from tablo2";
            sil.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("welcome.aspx");
        }

        protected void basla_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            
                        p.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory+"/sorucevapexe/sorucevapexe/bin/Debug/sorucevapexe.exe";
                        p.Start();
        }

        

        

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            sil = new OleDbCommand();
            sil.Connection = conn;
            sil.CommandText = "Delete * from tablo2";
            sil.ExecuteNonQuery();
            conn.Close();
        }

       

        protected void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            textbox2.ID = "textbox0";
            OleDbCommand sorusil = new OleDbCommand();
            sorusil.Connection = conn;
            string sil = "Delete * from sorular where soru=@sorue";
            OleDbCommand sorusilme = new OleDbCommand(sil, conn);
            sorusilme.Parameters.AddWithValue("sorue", textbox2.Text);
            sorusilme.ExecuteNonQuery();
            conn.Close();

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            sil = new OleDbCommand();
            sil.Connection = conn;
            sil.CommandText = "Delete * from sorular where konu= '" + DropDownList1.SelectedValue+ "'";
            sil.ExecuteNonQuery();
            conn.Close();
        }
    }
}