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
    public partial class oldquestions : System.Web.UI.Page
    {
        OleDbConnection conn = new OleDbConnection();
        DataSet ds;
        OleDbDataAdapter adapter;
        OleDbCommand cmd,komut,sil;
        OleDbDataReader Dreader;
        TextBox textbox1 = new TextBox();
        protected void Page_Load(object sender, EventArgs e)
        {

            
            Label1.Text = "Label";

        String baglanti = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/csharpsorucevap.accdb";
            conn.ConnectionString = baglanti;
            conn.Open();

            String konularisec = ("select konu from sorular");
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
            String Sorularisec = ("select soru from sorular where ogretmen = '" + Label1.Text + "' and konu = '" + DropDownList1.SelectedValue + "'");
            OleDbCommand cmd = new OleDbCommand(Sorularisec, conn);
            OleDbDataReader Dreader = cmd.ExecuteReader();
            
            string[] oku = new string[10];
            int i;
            i = 0;

            while (Dreader.Read()) {
                textbox1 = new TextBox();
                textbox1.ID = "textbox" + i.ToString();
                textbox1.Text = Dreader.GetValue(0).ToString();
                this.Panel1.Controls.Add(textbox1);




                komut = new OleDbCommand();
                komut.Connection = conn;
                komut.CommandText = "insert into tablo2 (ogretmen,konu,soru) values ('" + Label1.Text + "','" + DropDownList1.SelectedValue + "','" + textbox1.Text + "')";
                komut.ExecuteNonQuery();




                i = i + 1;

            }




            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
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
    }
}