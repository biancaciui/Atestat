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
    public partial class InfoCifraDestinului : Form
    {
        public InfoCifraDestinului()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {   
            //duce înapoi la formul cu Cifra Destinului și Zodia
            MeniuPrincipal f = new MeniuPrincipal();
            f.Show();
            Hide();
        }

        //instrucțiuni de legătura a butoanelor la site-urile potrivite
        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.horoscopurania.ro/cifra-destinului-1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.horoscopurania.ro/cifra-destinului-2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.horoscopurania.ro/cifra-destinului-3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.horoscopurania.ro/cifra-destinului-4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.horoscopurania.ro/cifra-destinului-5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.horoscopurania.ro/cifra-destinului-6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.horoscopurania.ro/cifra-destinului-7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.horoscopurania.ro/cifra-destinului-8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.horoscopurania.ro/cifra-destinului-9");
        }
        
        //instrucțiuni care țin de estetică
        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Snow;
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.ForestGreen;
            button1.Visible = button2.Visible = button3.Visible = button4.Visible = button5.Visible = button6.Visible = button7.Visible = button8.Visible = button9.Visible = false;
            pictureBox1.Visible = true;
            label6.Visible = false;
            label7.Visible = false;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            button1.Visible = button2.Visible = button3.Visible = button4.Visible = button5.Visible = button6.Visible = button7.Visible = button8.Visible = button9.Visible = true;
            label5.ForeColor = Color.Snow;
            label6.Visible = true;
            label7.Visible = true;
        }
        
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Snow;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Snow;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Snow;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Black;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Snow;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Black;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Snow;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.ForeColor = Color.Black;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.ForeColor = Color.Snow;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.ForeColor = Color.Black;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.ForeColor = Color.Snow;
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            button8.ForeColor = Color.Black;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.ForeColor = Color.Snow;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            button9.ForeColor = Color.Black;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.ForeColor = Color.Snow;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            CifraDestinului f = new CifraDestinului();
            f.Show();
            Hide();
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.ForeColor = Color.DarkCyan;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Snow;
        }
    }
}
