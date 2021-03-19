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

namespace Ciui_Bianca_Laura
{
    public partial class TestInternetAddict : Form
    {
        List<string> linii = new List<string>();
        int i = -1;//pentru liniile din listă

        public TestInternetAddict()
        {
            InitializeComponent();
        }
        
        //încărcarea fiecărei întrebări pe rând
        private void IncarcareContinut()
        {
            richTextBox1.Text = linii[++i];
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader("Intrebari_TestInternetAddict.txt");
            string s = f.ReadLine();
            while (s != null)
            {
                linii.Add(s);
                s = f.ReadLine();
            }
            AlegereaTestului.total = 0;//se inițializează cu 0 pentru fiecare întrare
        }

        private void AltaaIntrebareButton_Click(object sender, EventArgs e)
        {
            //nu se trece la întrebarea următoare, până nu se selectează un răspuns
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                MessageBox.Show("Nu ați selectat niciun răspuns, nu puteți trece mai departe!", "Atentionare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //totalizarea punctelor pentru fiecare întrebare
                if (radioButton2.Checked == true)
                    AlegereaTestului.total += 1;
                if (radioButton3.Checked == true)
                    AlegereaTestului.total += 2;
                //când se ajunge la ultima întrebare
                if (i == 14)
                {
                    AltaaIntrebareButton.Visible = false;
                    FinalizareeButton.Visible = true;
                    groupBox1.Visible = false;
                }
                if (i < linii.Count)
                    IncarcareContinut();
                //pentru fiecare nouă întrebare se deselectează toate cele 3 radiobutton-uri
                //asta ne asigură că utilizatorul a citit întrebarea, și nu trișează, răspunzând la fel la toate :)
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
        }

        private void FinalizareeButton_Click(object sender, EventArgs e)
        {
            //se încheie testul, se pregătește Formul cu rezultatele
            RezultateInternetAddict f = new RezultateInternetAddict();
            f.Show();
            Hide();
        }

        private void StarttButton_Click(object sender, EventArgs e)
        {
            //când se apasă, apar întrebările, răspunsurile și butonul de „Următoarea întrebare”
            label1.Visible = false;
            richTextBox1.Visible = true;
            groupBox1.Visible = true;
            AltaaIntrebareButton.Visible = true;
            StarttButton.Visible = false;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            IncarcareContinut();
        }

        private void AbandonareButton_Click(object sender, EventArgs e)
        {
            //când se apasă, totalul de până atunci se anulează, reapare Formul cu alegerea testului
            AlegereaTestului.total = 0;
            AlegereaTestului f = new AlegereaTestului();
            f.Show();
            Hide();
        }

        //instrucțiuni care țin de estetică
        private void StarttButton_MouseHover(object sender, EventArgs e)
        {
            StarttButton.ForeColor = Color.Navy;
            StarttButton.BackColor = Color.SlateBlue;
        }
        private void StarttButton_MouseLeave(object sender, EventArgs e)
        {
            StarttButton.ForeColor = Color.Black;
            StarttButton.BackColor = Color.DarkSlateBlue;
        }
        private void AltaaIntrebareButton_MouseLeave(object sender, EventArgs e)
        {
            AltaaIntrebareButton.ForeColor = Color.Black;
            AltaaIntrebareButton.BackColor = Color.DarkSlateBlue;
        }
        private void FinalizareeButton_MouseLeave(object sender, EventArgs e)
        {
            FinalizareeButton.ForeColor = Color.Black;
            FinalizareeButton.BackColor = Color.DarkSlateBlue;
        }
        private void FinalizareeButton_MouseHover(object sender, EventArgs e)
        {
            FinalizareeButton.ForeColor = Color.Navy;
            FinalizareeButton.BackColor = Color.SlateBlue;
        }
        private void AltaaIntrebareButton_MouseHover(object sender, EventArgs e)
        {
            AltaaIntrebareButton.ForeColor = Color.Navy;
            AltaaIntrebareButton.BackColor = Color.SlateBlue;
        }
        
        private void AbandonareButton_MouseHover(object sender, EventArgs e)
        {
            AbandonareButton.ForeColor = Color.DarkRed;
        }

        private void AbandonareButton_MouseLeave(object sender, EventArgs e)
        {
            AbandonareButton.ForeColor = Color.Snow;
        }
    }
}
