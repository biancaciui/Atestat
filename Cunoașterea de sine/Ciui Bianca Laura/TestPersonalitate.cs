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
    public partial class TestPersonalitate : Form
    {
        List<string> linii = new List<string>();
        int i = -1;//pentru liniile din listă
        
        public TestPersonalitate()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //când se apasă, apar întrebările, răspunsurile și butonul de „Următoarea întrebare”
            label2.Visible = false;
            AltaIntrebareButton.Visible = true;
            groupBox1.Visible = true;
            richTextBox1.Visible = true;
            StartButton.Visible = false;
            radioButton0.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton0.Text = "Nu mă caracterizează";
            radioButton1.Text = "Mă caracterizează puțin";
            radioButton2.Text = "Neutru";
            radioButton3.Text = "Uneori mă caracterizează";
            radioButton4.Text = "Mă caracterizează";
            IncarcareContinut();
        }

        //încărcarea fiecărei întrebări pe rând
        private void IncarcareContinut()
        {
            richTextBox1.Text = linii[++i];
        }

        private void TestPersonalitate_Load(object sender, EventArgs e)
        {
            label2.Visible = true;
            StreamReader f = new StreamReader("Intrebari_TestPersonalitate.txt");
            string s = f.ReadLine();
            while (s != null)
            {
                linii.Add(s);
                s = f.ReadLine();
            }
            AlegereaTestului.total = 0;
        }

        private void AltaIntrebareButton_Click(object sender, EventArgs e)
        {
            //nu se trece la întrebarea următoare, până nu se selectează un răspuns
            if (radioButton0.Checked == false && radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
                MessageBox.Show("Nu ați selectat niciun răspuns, nu puteți trece mai departe!", "Atentionare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //totalizarea punctelor pentru fiecare întrebare
                if (radioButton1.Checked == true)
                    AlegereaTestului.total += 0;
                if (radioButton2.Checked == true)
                    AlegereaTestului.total += 1;
                if (radioButton3.Checked == true)
                    AlegereaTestului.total += 2;
                if (radioButton4.Checked == true)
                    AlegereaTestului.total += 3;
                if (radioButton4.Checked == true)
                    AlegereaTestului.total += 4;
                //când se ajunge la ultima întrebare
                if (i==15)
                {
                    AltaIntrebareButton.Visible = false;
                    FinalizareTestButton.Visible = true;
                    groupBox1.Visible = false;
                }
                if (i < linii.Count)
                    IncarcareContinut();
                //pentru fiecare nouă întrebare se deselectează toate cele 3 radiobutton-uri
                //asta ne asigură că utilizatorul a citit întrebarea, și nu trișează, răspunzând la fel la toate :)
                radioButton0.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
        }

        private void FinalizareTestButton_Click(object sender, EventArgs e)
        {
            //se încheie testul, se pregătește Formul cu rezultatele
            RezultatePersonalitate f = new RezultatePersonalitate();
            f.Show();
            Hide();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            //când se apasă, totalul de până atunci se anulează, reapare Formul cu alegerea testului
            AlegereaTestului.total = 0;
            AlegereaTestului f = new AlegereaTestului();
            f.Show();
            Hide();
        }

        //instrucțiuni care țin de estetică
        private void StartButton_MouseHover(object sender, EventArgs e)
        {
            StartButton.ForeColor = Color.LightSkyBlue;
            StartButton.BackColor = Color.DarkCyan;
        }

        private void FinalizareTestButton_MouseHover(object sender, EventArgs e)
        {
            FinalizareTestButton.ForeColor = Color.LimeGreen;
            FinalizareTestButton.BackColor = Color.ForestGreen;
        }

        private void AltaIntrebareButton_MouseHover(object sender, EventArgs e)
        {
            AltaIntrebareButton.ForeColor = Color.LightSkyBlue;
            AltaIntrebareButton.BackColor = Color.DarkCyan;
        }

        private void StartButton_MouseLeave(object sender, EventArgs e)
        {
            StartButton.ForeColor = Color.DarkSlateGray;
            StartButton.BackColor = Color.CadetBlue;
        }

        private void AltaIntrebareButton_MouseLeave(object sender, EventArgs e)
        {
            AltaIntrebareButton.ForeColor = Color.DarkSlateGray;
            AltaIntrebareButton.BackColor = Color.CadetBlue;
        }

        private void FinalizareTestButton_MouseLeave(object sender, EventArgs e)
        {
            FinalizareTestButton.ForeColor = Color.DarkSlateGray;
            FinalizareTestButton.BackColor = Color.CadetBlue;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }
    }
}
