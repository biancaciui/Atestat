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

namespace Ciui_Bianca_Laura
{
    public partial class CreareContClient : Form
    {
        OleDbConnection con = new OleDbConnection();
        public CreareContClient()
        {
            //calea conexiunii
            InitializeComponent(); con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; 
            Data Source = " + Environment.CurrentDirectory + @"\Utilizatori.accdb";
        }

        //ieșire din Formul Creare Cont Client, reintrare în Formul de autentificare
        private void button2_Click(object sender, EventArgs e)
        {
            ///cand butonul de ieșire e apăsat, se șterg valorile deja introduse
            NumeTextBox.Text = PrenumeTextBox.Text =ZiuaComboBox.Text= "";
            LunaComboBox.Text=AnulComboBox.Text= emailTextBox.Text = "";
            ParolaTextBox.Text = ReintroducetiParolaTextBox.Text = "";
            Autentificare f = new Autentificare();
            f.Show();
            Hide();
        }

        private void CreareContButton_Click(object sender, EventArgs e)
        {
            //dacă în cadrul creării unui cont nou nu s-au introdus toate datele necesare, nu se crează contul
            if(NumeTextBox.Text=="" || PrenumeTextBox.Text=="" || ZiuaComboBox.Text=="" || LunaComboBox.Text =="" || AnulComboBox.Text == "" || emailTextBox.Text=="" || ParolaTextBox.Text =="" || ReintroducetiParolaTextBox.Text == "")
                MessageBox.Show("Vă rugăm completați toate câmpurile pentru a vă crea un cont!");
            else//dacă s-au introdus valori pentru toate câmpurile se crează contul
            {
                if (ParolaTextBox.Text != ReintroducetiParolaTextBox.Text)
                {
                    MessageBox.Show("Parolele nu sunt identice. Reintroduceți parola!");
                    ParolaTextBox.Text = ReintroducetiParolaTextBox.Text = "";
                }
                else
                {
                    //aici se face o căutare în DB după email-ul introdus, să vedem dacă acesta există deja
                    int idcontrol = 0;
                    string idcontr = "0";
                    string sqlcautare = "SELECT ID FROM Utilizatori " +
                        "WHERE email='" + emailTextBox.Text+"'";
                    con.Open();
                    OleDbCommand cmdcautare = new OleDbCommand(sqlcautare, con);
                    OleDbDataReader rdrcautare = cmdcautare.ExecuteReader();
                    while (rdrcautare.Read())
                    {
                        idcontr = rdrcautare["ID"].ToString();
                    }
                    con.Close();
                    idcontrol = int.Parse(idcontr);//aici avem ID-ul utilizatorului, dacă acesta există
                    if (idcontrol!=0)
                    {
                        MessageBox.Show("Email-ul introdus este deja folosit!");
                        emailTextBox.Text = "";
                    }
                    else
                    {
                        //dacă parolele sunt ientice și email-ul nu e folosit deja, se realizează preluarea datelor în DB
                        con.Open();
                        string sql = @"insert into Utilizatori (Nume,Prenume,email,Parola,ZiuaNasterii,
                                    LunaNasterii,AnulNasterii) " + " values ('" + NumeTextBox.Text + "','" + 
                                    PrenumeTextBox.Text + "','" + emailTextBox.Text + "','" + ParolaTextBox.Text + 
                                    "','" + ZiuaComboBox.Text + "','" + LunaComboBox.Text + "','" + AnulComboBox.Text + "')";
                        OleDbCommand cmd = new OleDbCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Mulțumim pentru înregistrare!");
                        con.Close();
                        //s-a realizat înregistrarea și preluarea datelor în DB, se revine la Formul de autentificare
                        Close();
                        Autentificare f = new Autentificare();
                        f.Show();
                    }
                }
                    
            }
        }

        //instrucțiuni care țin de estetică
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

        private void IesireButton_MouseHover(object sender, EventArgs e)
        {
            IesireButton.ForeColor = Color.Red;
            IesireButton.BackColor = Color.Maroon;
        }

        private void IesireButton_MouseLeave(object sender, EventArgs e)
        {
            IesireButton.ForeColor = Color.MidnightBlue;
            IesireButton.BackColor = Color.LightBlue;
        }
    }
}
