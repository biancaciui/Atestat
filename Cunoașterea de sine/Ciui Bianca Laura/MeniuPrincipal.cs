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
using System.IO;

namespace Ciui_Bianca_Laura
{
    public partial class MeniuPrincipal : Form
    {
        public static string fisierzodie = "";//îl vom folosi pentru a încărca în richtextbox fișierul cu zodia potrivită
        public static string fisiercifra = "";

        string numeleUtilizatorului;//reține prenumele utilizatorului, pentru o întâmpinare călduroasă :)
        public static int CifraDest = 0;
        public static int idziua=0, idluna=0, idanul=0;//aici sunt în forma de integer datele, inclusiv conversia lunii
        public static string idzodia = "";
        OleDbConnection con = new OleDbConnection();

        public MeniuPrincipal()
        {
            InitializeComponent();
            //calea conexiunii
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; 
            Data Source = " + Environment.CurrentDirectory + @"\Utilizatori.accdb";
        }

        //calculul sumei cifrelor
        private int sumacifre(int val)
        {
            int sum = 0;
            while (val != 0)
            {
                sum += val % 10;
                val /= 10;
            }
            return sum;
        }

        private void CifraDestinului_Zodia_Load(object sender, EventArgs e)
        {
            con.Open();
            string sqlziua = "SELECT ZiuaNasterii FROM Utilizatori " +
                "WHERE ID=" + User_id.id;
            string sqlluna = "SELECT LunaNasterii FROM Utilizatori " +
                "WHERE ID=" + User_id.id;
            string sqlanul = "SELECT AnulNasterii FROM Utilizatori " +
                "WHERE ID=" + User_id.id;

            //preluarea valorii zilei din DB
            OleDbCommand cmdziua = new OleDbCommand(sqlziua, con);
            OleDbDataReader rdrziua = cmdziua.ExecuteReader();
            while (rdrziua.Read())
            {
                string ziua = rdrziua["ZiuaNasterii"].ToString();
                idziua = Int32.Parse(ziua);//conversie de la string la integer
            }

            //preluarea valorii lunii din DB
            OleDbCommand cmdluna = new OleDbCommand(sqlluna, con);
            OleDbDataReader rdrluna = cmdluna.ExecuteReader();
            while (rdrluna.Read())
            {
                //conversie din formatul din DB în format accesibil operației de calculare a Cifrei Destinului
                string luna = rdrluna["LunaNasterii"].ToString();
                if (luna == "ianuarie")
                    idluna = 1;
                if (luna == "februarie")
                    idluna = 2;
                if (luna == "martie")
                    idluna = 3;
                if (luna == "aprilie")
                    idluna = 4;
                if (luna == "mai")
                    idluna = 5;
                if (luna == "iunie")
                    idluna = 6;
                if (luna == "iulie")
                    idluna = 7;
                if (luna == "august")
                    idluna = 8;
                if (luna == "septembrie")
                    idluna = 9;
                if (luna == "octombrie")
                    idluna = 10;
                if (luna == "noiembrie")
                    idluna = 11;
                if (luna == "decembrie")
                    idluna = 12;
            }

            //preluarea valorii anului din DB
            OleDbCommand cmdanul = new OleDbCommand(sqlanul, con);
            OleDbDataReader rdranul = cmdanul.ExecuteReader();
            while (rdranul.Read())
            {
                string anul = rdranul["AnulNasterii"].ToString();
                idanul = Int32.Parse(anul);//conversie la integer de la string
            }
            
            //calculul efectiv al Ciferi Destinului
            int suma = 0;
            suma = idanul + idluna + idziua;
            while (suma > 9)
                suma = sumacifre(suma);            
            CifraDest = suma;//e cifra de control

            //actualizare în DB a Cifrei Destinului, imediat cum o aflăm
            con.Close();
            con.Open();
            string sqlCifDest = @"UPDATE Utilizatori 
                        set CifraDestinului=" + CifraDest.ToString()+" WHERE ID="+User_id.id;
            OleDbCommand cmdCifDest = new OleDbCommand(sqlCifDest, con);
            cmdCifDest.ExecuteNonQuery();
            
            //aici se alege numele utilizatorului, ca să îi spunem pe nume când îi afișăm Cifra Destinului
            string sqlprenume = "SELECT Prenume FROM Utilizatori " +
                "WHERE ID=" + User_id.id;
            OleDbCommand cmdprenume = new OleDbCommand(sqlprenume, con);
            OleDbDataReader rdrprenume = cmdprenume.ExecuteReader();
            while (rdrprenume.Read())
            {
                numeleUtilizatorului = rdrprenume["Prenume"].ToString();
            }

            //aici e codul pentru label-urile care intră în întâmpinarea utilozatorului
            label4.Text = "Bună, " + numeleUtilizatorului.ToString() + "! Ce ai vrea să aflii despre tine?";
            con.Close();

            //aici se alege fișierul corespunzător Cifrei Destinului
            fisiercifra = CifraDest.ToString() + "." + "txt";

            //aici este secvența care alege zodia corectă, în funcție de lună și zi
            if ((idluna == 1 && idziua >= 20) || (idluna == 2 && idziua <= 18))
                idzodia = "varsator";
            if ((idluna == 2 && idziua >= 19) || (idluna == 3 && idziua <= 20))
                idzodia = "pesti";
            if ((idluna == 3 && idziua >= 21) || (idluna == 4 && idziua <= 20))
                idzodia = "berbec";
            if ((idluna == 4 && idziua >= 21) || (idluna == 5 && idziua <= 20))
                idzodia = "taur";
            if ((idluna == 5 && idziua >= 21) || (idluna == 6 && idziua <= 21))
                idzodia = "gemeni";
            if ((idluna == 6 && idziua >= 22) || (idluna == 7 && idziua <= 22))
                idzodia = "rac";
            if ((idluna == 7 && idziua >= 23) || (idluna == 8 && idziua <= 22))
                idzodia = "leu";
            if ((idluna == 8 && idziua >= 23) || (idluna == 9 && idziua <= 22))
                idzodia = "fecioara";
            if ((idluna == 9 && idziua >= 23) || (idluna == 10 && idziua <= 22))
                idzodia = "balanta";
            if ((idluna == 10 && idziua >= 23) || (idluna == 11 && idziua <= 21))
                idzodia = "scorpion";
            if ((idluna == 11 && idziua >= 22) || (idluna == 12 && idziua <= 20))
                idzodia = "sagetator";
            if ((idluna == 12 && idziua >= 21) || (idluna == 1 && idziua <= 19))
                idzodia = "capricorn";
            fisierzodie = idzodia+".txt";

            //aici se introduce zodia in baza de date
            con.Open();
            string sqlUpdateZodia = @"UPDATE Utilizatori 
                        set Zodia='" + idzodia + "' WHERE ID=" + User_id.id;
            OleDbCommand cmdUpdateZodia = new OleDbCommand(sqlUpdateZodia, con);
            cmdUpdateZodia.ExecuteNonQuery();
            con.Close();
        }

        //instrucțiuni ce țin de închiderea și deschiderea Form-urilor
        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void incearcaLabel_MouseClick(object sender, MouseEventArgs e)
        {
            AlegereaTestului f = new AlegereaTestului();
            f.Show();
            Hide();
        }

        private void ieșireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zodieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoZodie f = new InfoZodie();
            f.Show();
            Hide();
        }

        private void cifraDestinuluiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoCifraDestinului f = new InfoCifraDestinului();
            f.Show();
            Hide();
        }

        private void zodieButton_Click(object sender, EventArgs e)
        {
            Zodie f = new Zodie();
            f.Show();
            Hide();
        }

        private void CifraDestinuluiButton_Click(object sender, EventArgs e)
        {
            CifraDestinului f = new CifraDestinului();
            f.Show();
            Hide();
        }

        //instrucțiuni ce țin de estetică
        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Snow;
        }
        
        private void incearcaLabel_MouseHover(object sender, EventArgs e)
        {
            incearcaLabel.ForeColor = Color.ForestGreen;
        }

        private void incearcaLabel_MouseLeave(object sender, EventArgs e)
        {
            incearcaLabel.ForeColor = Color.Snow;
        }
        
        private void informațiiGeneraleToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            informațiiGeneraleToolStripMenuItem.ForeColor = Color.Black;
        }

        private void informațiiGeneraleToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            informațiiGeneraleToolStripMenuItem.ForeColor = Color.Snow;
        }

        private void ieșireToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            ieșireToolStripMenuItem.ForeColor = Color.Red;
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
            zodieButton.Visible = CifraDestinuluiButton.Visible = true;
            label4.Visible = true;
        }

        private void ieșireToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ieșireToolStripMenuItem.ForeColor = Color.Snow;
        }
    }
}
