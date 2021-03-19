using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace Ciui_Bianca_Laura
{
    public partial class Autentificare : Form
    {
        public int sem = 0;
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        OleDbConnection con = new OleDbConnection();

        public Autentificare()
        {
            InitializeComponent();
            player.URL = "The XX - Intro.mp3";//numele fișierului care va fi pornit
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; 
             Data Source = " + Environment.CurrentDirectory + @"\Utilizatori.accdb";
        }
        
        private void LoginButton_Click(object sender, EventArgs e)
        {
            ///daca nu s-au introdus datele necesare autentificarii, un mesaj va apărea pe ecran
            int semlogin = 0;//ne asigură de faptul ca dacă introducem doar un câmp, să nu ne apară și mesajul de atenționare cum că am introdus o combinație greșită email-parolă
            if (emailTextBox.Text=="" || ParolaTextBox.Text=="")
            {
                ///daca nu s-au introdus datele necesare autentificarii, un mesaj va apărea pe ecran
                MessageBox.Show("Vă rugăm să introduceți toate datele necesare!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                semlogin = 1;//se notează faptul că s-a afișat deja un mesaj de atenționare, nu-l afișează și pe următorul
            }
            int ct = 0, id = 0;
            con.Open();
            string sql = "select ID from Utilizatori " +
                "where email='" + emailTextBox.Text + "'" +
                " and Parola='" + ParolaTextBox.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ct++;
                id = int.Parse(rdr[0].ToString());
                User_id.id = id;
            }
            if (ct > 0)
            {
                MessageBox.Show("Autentificare reușită!", "Bine ai venit!", MessageBoxButtons.OK, MessageBoxIcon.None);
                MeniuPrincipal f = new MeniuPrincipal();
                f.Show();
                Hide();
            }
            else
            {
                if(semlogin==0)//dacă nu s-a afișat primul mesaj de atenționare, se va afișa acesta
                    MessageBox.Show("Email sau parolă greșită! Reîncearcă!", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                emailTextBox.Text = ParolaTextBox.Text = "";//se golesc textboxurile pentru următoarea serie de valori introduse
            }
            con.Close();
        }

        private void Autentificare_Load(object sender, EventArgs e)
        {
            if(sem==0)//sem ne asigură că piesa va începe o singură dată (sau măcar ar trebui)
            {
                player.controls.play();
                sem = 1;
            }
        }

        private void iesireButton_Click(object sender, EventArgs e)
        {
            //iesire din program
            Application.Exit();
        }

        private void CreareContButton_Click(object sender, EventArgs e)
        {
            ///buton ce duce la deschiderea Formului de Creare Cont Nou
            CreareContClient f = new CreareContClient();
            f.Show();
            Hide();
        }
        
        //instrucțiuni care țin de estetică
        private void iesireButton_MouseHover(object sender, EventArgs e)
        {
            iesireButton.ForeColor = Color.Red;
            iesireButton.BackColor = Color.Maroon;
        }

        private void iesireButton_MouseLeave(object sender, EventArgs e)
        {
            iesireButton.ForeColor = Color.MidnightBlue;
            iesireButton.BackColor = Color.LightBlue;
        }

        private void LoginButton_MouseHover(object sender, EventArgs e)
        {
            LoginButton.ForeColor = Color.Navy;
            LoginButton.BackColor = Color.SteelBlue;
        }

        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.ForeColor = Color.MidnightBlue;
            LoginButton.BackColor = Color.LightBlue;
        }

        private void CreareContButton_MouseHover(object sender, EventArgs e)
        {
            CreareContButton.ForeColor = Color.Navy;
            CreareContButton.BackColor = Color.SteelBlue;
        }

        private void CreareContButton_MouseLeave(object sender, EventArgs e)
        {
            CreareContButton.ForeColor = Color.MidnightBlue;
            CreareContButton.BackColor = Color.LightBlue;
        }
    }
}
