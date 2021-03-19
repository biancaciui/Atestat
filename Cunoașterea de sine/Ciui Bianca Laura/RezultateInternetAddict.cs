using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Ciui_Bianca_Laura
{
    public partial class RezultateInternetAddict : Form
    {
        OleDbConnection con = new OleDbConnection();

        public RezultateInternetAddict()
        {
            InitializeComponent();
            //calea conexiunii
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; 
            Data Source = " + Environment.CurrentDirectory + @"\Utilizatori.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //buton de revenire la meniul de alegere a testului
            AlegereaTestului f = new AlegereaTestului();
            f.Show();
            Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //aici rezultatul, în funcție de totalul obținut, se încadrează într-o categorie
            if (AlegereaTestului.total <= 14)
            {
                StreamReader f = new StreamReader("TestInternet-1lvl.txt");
                string s = f.ReadToEnd();
                richTextBox1.Text = s;
            }
            if (AlegereaTestului.total >= 15 && AlegereaTestului.total <= 19)
            {
                StreamReader f = new StreamReader("TestInternet-2lvl.txt");
                string s = f.ReadToEnd();
                richTextBox1.Text = s;
            }
            if (AlegereaTestului.total >= 20 && AlegereaTestului.total<=29)
            {
                StreamReader f = new StreamReader("TestInternet-3lvl.txt");
                string s = f.ReadToEnd();
                richTextBox1.Text = s;
            }
            if (AlegereaTestului.total >= 30)
            {
                StreamReader f = new StreamReader("TestInternet-4lvl.txt");
                string s = f.ReadToEnd();
                richTextBox1.Text = s;
            }
            //afișarea punctajului
            label1.Text = "Ai obținut un punctaj de " + AlegereaTestului.total + " de puncte!";
            
            //actualizarea datelor obținute în evaluarea răspunsurilor în DB
            con.Open();
            string sql = @"UPDATE Utilizatori 
                        set InternetAddict=" + AlegereaTestului.total+@" 
                        WHERE ID="+User_id.id;
            OleDbCommand cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //instrucțiuni care țin de estetică
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.MidnightBlue;
            button1.BackColor = Color.RosyBrown;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.DarkSlateGray;
            button1.BackColor = Color.Thistle;
        }
    }
}
