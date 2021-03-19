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
    public partial class Zodie : Form
    {
        public Zodie()
        {
            InitializeComponent();
        }
        
        private void Zodie_Load(object sender, EventArgs e)
        {
            //aici se încarcă fișierul cu zodia corect, după luna și ziua nașterii
            StreamReader fzod = new StreamReader(MeniuPrincipal.fisierzodie);
            zodieRichTextBox.Text = fzod.ReadToEnd();

            //aici, în funcție de fișierul curent, se actualizează imaginea de fundal cu planeta caracteristică zodiei
            if (MeniuPrincipal.fisierzodie == "berbec.txt")
                this.BackgroundImage = Properties.Resources.soare;
            if (MeniuPrincipal.fisierzodie == "taur.txt")
                this.BackgroundImage = Properties.Resources.luna;
            if (MeniuPrincipal.fisierzodie == "gemeni.txt")
                this.BackgroundImage = Properties.Resources.uranus;
            if (MeniuPrincipal.fisierzodie == "rac.txt")
                this.BackgroundImage = Properties.Resources.jupiter;
            if (MeniuPrincipal.fisierzodie == "leu.txt")
                this.BackgroundImage = Properties.Resources.neptun;
            if (MeniuPrincipal.fisierzodie=="fecioara.txt")
                this.BackgroundImage = Properties.Resources.mercur;
            if (MeniuPrincipal.fisierzodie == "balanta.txt")
                this.BackgroundImage = Properties.Resources.saturn;
            if (MeniuPrincipal.fisierzodie == "scorpion.txt")
                this.BackgroundImage = Properties.Resources.uranus;
            if (MeniuPrincipal.fisierzodie == "sagetator.txt")
                this.BackgroundImage = Properties.Resources.pluto;
            if (MeniuPrincipal.fisierzodie == "capricorn.txt")
                this.BackgroundImage = Properties.Resources.marte;
            if (MeniuPrincipal.fisierzodie == "varsator.txt")
                this.BackgroundImage = Properties.Resources.mercur;
            if (MeniuPrincipal.fisierzodie == "pesti.txt")
                this.BackgroundImage = Properties.Resources.venus;
        }

        //aici sunt instrucțiuni ce țin de deschiderea altor formuri
        private void label1_Click(object sender, EventArgs e)
        {
            InfoZodie f = new InfoZodie();
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
