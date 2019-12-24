using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace sorucevapexe
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection();
        DataSet ds;
        OleDbDataAdapter adapter;
        OleDbCommand cmd, komut, sil;
        OleDbDataReader Dreader;
        int sorusayisi = 0,dogru=0, yanlis=0;

        string ogretmen;
        string[] oku = new string[100];
        string[] soru = new string[100];
        string[] dcevap = new string[100];
        string[] yc1 = new string[100];
        string[] yc2 = new string[100];
        string[] yc3 = new string[100];
        static string path=AppDomain.CurrentDomain.BaseDirectory;
        static string kesilmispath = path.Substring(0, path.LastIndexOf("son"));
        string baglanti = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+kesilmispath+ "/son/App_Data/csharpsorucevap.accdb";

        public Form1()
        {
            
            conn.ConnectionString = baglanti;
            InitializeComponent();
        }
        void sonrakisoru()
        {
            Random rastgelesayi = new Random();
            int rastgele = rastgelesayi.Next(1,5);
            label1.Text = soru[sorusayisi];
            if(rastgele==1)
            {
                button1.Text = dcevap[sorusayisi];
                button2.Text = yc1[sorusayisi];
                button3.Text = yc2[sorusayisi];
                button4.Text = yc3[sorusayisi];
            }
            if (rastgele == 2)
            {
                button1.Text = yc1[sorusayisi];
                button2.Text = dcevap[sorusayisi];
                button3.Text = yc2[sorusayisi];
                button4.Text = yc3[sorusayisi];
            }
            if (rastgele == 3)
            {
                button1.Text = yc1[sorusayisi];
                button2.Text = yc2[sorusayisi];
                button3.Text = dcevap[sorusayisi]; 
                button4.Text = yc3[sorusayisi];
            }
            if (rastgele == 4)
            {
                button1.Text = yc3[sorusayisi];
                button2.Text = yc1[sorusayisi];
                button3.Text = yc2[sorusayisi];
                button4.Text = dcevap[sorusayisi];
            }
            if(soru[sorusayisi]=="son")
            {
                MessageBox.Show("Tebrikler Oyun bitti \n Dogru Sayınız: "+dogru+"\n yanlış sayınız: "+yanlis);

                conn.Open();
                sil = new OleDbCommand();
                sil.Connection = conn;
                sil.CommandText = "Delete * from tablo2";
                sil.ExecuteNonQuery();
                conn.Close();
                
            }
        }

        int x;
        private void Form1_Load(object sender, EventArgs e)
        {

            label3.Text = kesilmispath;

            timer1.Interval = 100;
            timer2.Interval = 100;





            /////////////////////////KONUYU AL
            conn.Open();
            string konuyual = ("select * from tablo2 "); //2 konu
            OleDbCommand konuyucek = new OleDbCommand(konuyual, conn);
            OleDbDataReader konuoku = konuyucek.ExecuteReader();
            konuoku.Read();
            
            string x = konuoku[2].ToString();
            label2.Text = x;






            /////////////////////////////
            string cevaplar = ("select * from sorular where konu = '" + konuoku[2].ToString()+ "' ");

            OleDbCommand sorulartablosu = new OleDbCommand(cevaplar, conn);
            OleDbDataReader Dreader = sorulartablosu.ExecuteReader();
            ////////////////////////////////////////// KONUNU OLDUĞU SORULAR TABLOSUNDA FALAN FİLAN


            int i = 0;
            // 1 ogretmen 4 dogru  5-6-7 yanlış 8 soru
            while (Dreader.Read())
            {
                ogretmen = Dreader[1].ToString();
                
                dcevap[i] = Dreader[4].ToString();
                yc3[i] = Dreader[5].ToString();
                yc1[i] = Dreader[6].ToString();
                yc2[i] = Dreader[7].ToString();
                soru[i] = Dreader[8].ToString();
                i++;
            }
            soru[i] = "son";
            label2.Text = ogretmen+" "+label2.Text;
            
            sonrakisoru();
            conn.Close();
            timer1.Interval = 500;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == dcevap[sorusayisi])
            {
                MessageBox.Show("bravo");
                sorusayisi++;
                sonrakisoru();
                dogru++;
            }
            else
            {
                x = 0;
                yanlis++;
                timer1.Start();
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == dcevap[sorusayisi])
            {
                MessageBox.Show("bravo");
                sorusayisi++;
                sonrakisoru();
                dogru++;
            }
            else
            {
                x = 0;
                yanlis++;
                timer1.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Text == dcevap[sorusayisi])
            {
                MessageBox.Show("bravo");
                sorusayisi++;
                sonrakisoru();
                dogru++;
            }
            else
            {
                x = 0;
                yanlis++;
                timer1.Start();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == dcevap[sorusayisi])
            {
                MessageBox.Show("bravo");
                sorusayisi++;
                sonrakisoru();
                dogru++;
            }
            else
            {
                x = 0;
                yanlis++;
                timer1.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
            button1.Location = new Point(button1.Location.X + 5, 127);
            
            x = x + 1;
            if (x == 2)
            {
                button1.Location = new Point(button1.Location.X - 10, 127);
                this.BackColor = System.Drawing.Color.WhiteSmoke;
                
                timer1.Stop();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.ForestGreen;
            button1.Location = new Point(button1.Location.X + 5, 127);

            x = x + 1;
            if (x == 2)
            {
                button1.Location = new Point(button1.Location.X - 10, 127);
                this.BackColor = System.Drawing.Color.WhiteSmoke;

                timer1.Stop();
            }
        }



    }
}
