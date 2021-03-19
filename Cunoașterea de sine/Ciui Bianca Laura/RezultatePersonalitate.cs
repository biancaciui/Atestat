using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciui_Bianca_Laura
{

    public partial class RezultatePersonalitate : Form
    {
        OleDbConnection con = new OleDbConnection();
        public RezultatePersonalitate()
        {
            InitializeComponent();
            //calea conexiunii
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; 
            Data Source = " + Environment.CurrentDirectory + @"\Utilizatori.accdb";
        }

        private void RevenireButton_Click(object sender, EventArgs e)
        {
            //buton de revenire la meniul de alegere a testului
            AlegereaTestului f = new AlegereaTestului();
            f.Show();
            Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //aici rezultatul, în funcție de totalul obținut, se încadrează într-o categorie
            if (AlegereaTestului.total<27)
            {
                StreamReader f = new StreamReader("TestPersonalitate-1lvl.txt");
                string s = f.ReadToEnd();
                richTextBox1.Text = s;
            }
            if (AlegereaTestului.total >= 27 && AlegereaTestului.total<=45)
            {
                StreamReader f = new StreamReader("TestPersonalitate-2lvl.txt");
                string s = f.ReadToEnd();
                richTextBox1.Text = s;
            }
            if (AlegereaTestului.total>45)
            {
                StreamReader f = new StreamReader("TestPersonalitate-3lvl.txt");
                string s = f.ReadToEnd();
                richTextBox1.Text = s;
            }
            //afișarea punctajului
            label1.Text = "Ai obținut un punctaj de " + AlegereaTestului.total + " de puncte!";

            //actualizarea datelor obținute în evaluarea răspunsurilor în DB
            con.Open();
            string sql = @"UPDATE Utilizatori 
                        set Personalitate=" + AlegereaTestului.total + @" 
                        WHERE ID=" + User_id.id;
            OleDbCommand cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //instrucțiuni care țin de estetică
        private void RevenireButton_MouseHover(object sender, EventArgs e)
        {
            RevenireButton.ForeColor = Color.MidnightBlue;
            RevenireButton.BackColor = Color.RosyBrown;
        }

        private void RevenireButton_MouseLeave(object sender, EventArgs e)
        {
            RevenireButton.ForeColor = Color.DarkSlateGray;
            RevenireButton.BackColor = Color.Thistle;
        }
    }
}
