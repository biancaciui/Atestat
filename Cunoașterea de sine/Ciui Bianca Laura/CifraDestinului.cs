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
    public partial class CifraDestinului : Form
    {
        public CifraDestinului()
        {
            InitializeComponent();
        }
        
        private void CifraDestinului_Load(object sender, EventArgs e)
        {
            //aici se afișează fișierul corespunzător pentru utilizator
            StreamReader fcif = new StreamReader(MeniuPrincipal.fisiercifra);
            cifraRichTextBox.Text = fcif.ReadToEnd();

            //aici, în funcție de fișierul curent, se actualizează imaginea de fundal cu planeta caracteristică cifrei destinului
            if (MeniuPrincipal.fisiercifra == "1.txt")
                this.BackgroundImage = Properties.Resources.soare;
            if (MeniuPrincipal.fisiercifra == "2.txt")
                this.BackgroundImage = Properties.Resources.luna;
            if (MeniuPrincipal.fisiercifra == "3.txt")
                this.BackgroundImage = Properties.Resources.marte;
            if (MeniuPrincipal.fisiercifra == "4.txt")
                this.BackgroundImage = Properties.Resources.mercur;
            if (MeniuPrincipal.fisiercifra == "5.txt")
                this.BackgroundImage = Properties.Resources.jupiter;
            if (MeniuPrincipal.fisiercifra == "6.txt")
                this.BackgroundImage = Properties.Resources.venus;
            if (MeniuPrincipal.fisiercifra == "7.txt")
                this.BackgroundImage = Properties.Resources.saturn;
            if (MeniuPrincipal.fisiercifra == "8.txt")
                this.BackgroundImage = Properties.Resources.uranus;
            if (MeniuPrincipal.fisiercifra == "9.txt")
                this.BackgroundImage = Properties.Resources.neptun;
        }

        //aici sunt instrucțiuni ce țin de deschiderea altor formuri
        private void label1_Click(object sender, EventArgs e)
        {
            InfoCifraDestinului f = new InfoCifraDestinului();
            f.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MeniuPrincipal f = new MeniuPrincipal();
            f.Show();
            Hide();
        }

        //aici sunt instrucțiuni ce țin de estetică
        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.ForestGreen;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.PaleTurquoise;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Snow;
        }
    }
}
