using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ciui_Bianca_Laura
{
    public partial class InfoZodie : Form
    {
        public InfoZodie()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MeniuPrincipal f = new MeniuPrincipal();
            f.Show();
            Hide();
        }

        //instrucțiuni care afișează informații despre zodia respectivă când se trece cu mouse-ul deasupra butoanelor
        private void berbecButton_MouseHover(object sender, EventArgs e)
        {
            zodiaLabel.Text = "Berbeci sunt cei născuți între datele 21 martie și 20 aprilie. Doriți să citiți horoscopul zilei pentru berbeci?";
        }

        private void taurButton_MouseHover(object sender, EventArgs e)
        {
            zodiaLabel.Text = "Tauri sunt cei născuți între datele 21 aprilie și 21 mai. Doriți să citiți horoscopul zilei pentru tauri?";
        }

        private void gemeniButton_MouseHover(object sender, EventArgs e)
        {
            zodiaLabel.Text = "Gemeni sunt cei născuți între datele 22 mai și 20 iunie. Doriți să citiți horoscopul zilei pentru gemeni?";
        }

        private void racButton_MouseHover(object sender, EventArgs e)
        {
            zodiaLabel.Text = "Raci sunt cei născuți între datele 21 iunie și 22 iulie. Doriți să citiți horoscopul zilei pentru raci?";
        }

        private void leuButton_MouseHover(object sender, EventArgs e)
        {
            zodiaLabel.Text = "Lei sunt cei născuți între datele 23 iulie și 22 august. Doriți să citiți horoscopul zilei pentru lei?";
        }

        private void fecioaraButton_MouseHover(object sender, EventArgs e)
        {
            zodiaLabel.Text = "Fecioare sunt cei născuți între datele 23 august și 22 septembrie. Doriți să citiți horoscopul zilei pentru fecioare?";
        }

        private void balantaButton_MouseHover(object sender, EventArgs e)
        {
            zodiaLabel.Text = "Balanțe sunt cei născuți între datele 23 septembrie și 22 octombrie. Doriți să citiți horoscopul zilei pentru balanțe?";
        }

        private void scorpionButton_MouseHover(object sender, EventArgs e)
        {
            zodiaLabel.Text = "Scorpioni sunt cei născuți între datele 23 octombrie și 21 noiembrie. Doriți să citiți horoscopul zilei pentru scorpioni?";
        }

        private void sagetatorButton_MouseHover(object sender, EventArgs e)
        {
            zodiaLabel.Text = "Săgetători sunt cei născuți între datele 22 noiembrie și 21 decembrie. Doriți să citiți horoscopul zilei pentru săgetători?";
        }

        private void capricornButton_MouseHover(object sender, EventArgs e)
        {
            zodiaLabel.Text = "Capicorni sunt cei născuți între datele 22 decembrie și 19 ianuarie. Doriți să citiți horoscopul zilei pentru capricorni?";
        }

        private void varsatorButton_MouseHover(object sender, EventArgs e)
        {
            zodiaLabel.Text = "Vărsători sunt cei născuți între datele 20 ianuarie și 18 februarie. Doriți să citiți horoscopul zilei pentru vărsători?";
        }

        private void pestiButton_MouseHover(object sender, EventArgs e)
        {
            zodiaLabel.Text = "Pești sunt cei născuți între datele 19 februarie și 20 martie. Doriți să citiți horoscopul zilei pentru pești?";
        }

        private void berbecButton_MouseLeave(object sender, EventArgs e)
        {
            zodiaLabel.Text = "";
        }
        private void taurButton_MouseLeave(object sender, EventArgs e)
        {
            zodiaLabel.Text = "";
        }

        private void gemeniButton_MouseLeave(object sender, EventArgs e)
        {
            zodiaLabel.Text = "";
        }

        private void racButton_MouseLeave(object sender, EventArgs e)
        {
            zodiaLabel.Text = "";
        }

        private void leuButton_MouseLeave(object sender, EventArgs e)
        {
            zodiaLabel.Text = "";
        }

        private void fecioaraButton_MouseLeave(object sender, EventArgs e)
        {
            zodiaLabel.Text = "";
        }

        private void balantaButton_MouseLeave(object sender, EventArgs e)
        {
            zodiaLabel.Text = "";
        }

        private void scorpionButton_MouseLeave(object sender, EventArgs e)
        {
            zodiaLabel.Text = "";
        }

        private void sagetatorButton_MouseLeave(object sender, EventArgs e)
        {
            zodiaLabel.Text = "";
        }

        private void capricornButton_MouseLeave(object sender, EventArgs e)
        {
            zodiaLabel.Text = "";
        }

        private void varsatorButton_MouseLeave(object sender, EventArgs e)
        {
            zodiaLabel.Text = "";
        }

        private void pestiButton_MouseLeave(object sender, EventArgs e)
        {
            zodiaLabel.Text = "";
        }

        //instrucțiuni care fac legătura între butoane si site-urile caracteristice fiecărei zodii
        private void berbecButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.horoscop.ro/berbec/");
        }

        private void taurButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.horoscop.ro/taur/");
        }

        private void gemeniButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.horoscop.ro/gemeni/");
        }

        private void racButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.horoscop.ro/rac/");
        }

        private void leuButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.horoscop.ro/leu/");
        }

        private void fecioaraButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.horoscop.ro/fecioara/");
        }

        private void balantaButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.horoscop.ro/balanta/");
        }

        private void scorpionButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.horoscop.ro/scorpion/");
        }

        private void sagetatorButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.horoscop.ro/sagetator/");
        }

        private void capricornButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.horoscop.ro/capricorn/");
        }

        private void varsatorButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.horoscop.ro/varsator/");
        }

        private void pestiButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.horoscop.ro/pesti/");
        }

        //instrucțiuni care țin de estetică și legături între Formuri
        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Snow;
        }
        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.ForestGreen;
            label2.Visible = false;
            label3.Visible = false;
            pictureBox1.Visible = true;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Snow;
            label2.Visible = true;
            label3.Visible = true;
            pictureBox1.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Zodie f = new Zodie();
            f.Show();
            Hide();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.DarkCyan;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Snow;
        }
    }
}
