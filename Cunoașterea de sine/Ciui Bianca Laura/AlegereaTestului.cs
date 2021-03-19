using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ciui_Bianca_Laura
{
    public partial class AlegereaTestului : Form
    {
        //acest total este folosit pentru ambele teste, pentru generarea rezultatelor
        public static int total = 0;
        
        public AlegereaTestului()
        {
            InitializeComponent();
        }

        private void ieșireToolStripMenuItem_Click(object sender, EventArgs e)
        {   //buton de ieșire
            Application.Exit();
        }

        //aici urmează butoanele de pe menuStrip responsabile cu explicarea diverselor acțiuni și reguli
        private void modDeCalculAlScoruluiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tÎn funcție de răspunsurile date de dumneavoastră în cadrul testului, vom aduna punctele corespondente fiecărui răspuns și în funcție de acestea vă putem indica categoria în care vă încadrați. \n\tTotuși acest test nu este menit să facă diagnosticări așa că pentru un răspuns concret vă rugăm să consultați un specialist!", "Modul de calcul al rezultatului", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        private void testulDePersonalitateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tAcest concept după care este creat testul de personalitate a fost dezvoltat de Dr. Ernest Hartmann de la Universitatea Tufts și este un mod eficient de a vedea diferențele dintre indivizi dar și de a înțelege de ce unii oameni dezvoltă boli cronice care sunt complet diferite de bolile cronice dezvoltate de alte persoane.\n\tPrin cele trei categorii, se poate măsura capacitatea unui om de a avea o gândire deschisă sau nu, de a fi introvertit sau extrovertit, capacitatea lui de a se face agreat de cei din jur sau de a spune adevărul.Prin acest test se poate observa felul în care o persoană se vede pe sine dar și pe cei din jur și felul în care acesta reacționează la diferite energii și sentimente.Prin aceast nou tip de a categorisi personalitățiile oamenilor putem vedea cum trăirile îi afectează pe indivizi pe planul intern.\n\tDupă spusele Dr.Hartmann: „Există oameni care sunt fotărâți și bine organizați.Ei par a fi rigizi în relațiile cu ceilalți așa că, în acest domeniu îi numim oameni << cu piele groasă >>.Aceste persoane, din punctul meu de vedere, se află la capătul opus față de persoanele în special sensibile, deschise și vulnerabile. În mintea celor din urmă totul este fluid.”\n\tTotuși acest test nu este un mod de diagnosticare așa că pentru un rezultat concret, vă recomandăm să vizitați un specialist în domeniu.", "Despre testul de personalitate", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void testulInternetAddictionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tAcest test este menit pentru a vă face o idee despre felul în care utilizați internetul, dacă această libertate pe care o aveți este una sănătoasă sau nu pentru viața dumneavoastră. Desigur, nimic nu e bun în cantități mari, așa că vă invit să urmați pașii din instrucțiuni înainte de a începe testul pentru a puteaobține un rezultat cât mai aproape de adevăr.\n\t Totuși acest test nu este un mod de diagnosticare așa că pentru un rezultat concret, vă recomandăm să vizitați un specialist în domeniu.", "Despre testul „Internet Addict”", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //aici sunt instrucțiuni responsabile de deschiderea formurilor
        private void label1_Click(object sender, EventArgs e)
        {
            MeniuPrincipal f = new MeniuPrincipal();
            f.Show();
            Hide();
        }

        private void instrucțiuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instructiuni f = new Instructiuni();
            f.Show();
            Hide();
        }
        
        private void TestPersonalitateButton_Click(object sender, EventArgs e)
        {
            TestPersonalitate f = new TestPersonalitate();
            f.Show();
            Hide();
        }

        private void TestInternetAddictButton_Click(object sender, EventArgs e)
        {
            TestInternetAddict f = new TestInternetAddict();
            f.Show();
            Hide();
        }

        private void revenireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeniuPrincipal f = new MeniuPrincipal();
            f.Show();
            Hide();
        }
        
        //instrucțiuni ce țin de estetică
        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Maroon;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void revenireToolStripMenuItem_MouseHover_1(object sender, EventArgs e)
        {
            revenireToolStripMenuItem.ForeColor = Color.Red;
        }

        private void revenireToolStripMenuItem_MouseLeave_1(object sender, EventArgs e)
        {
            revenireToolStripMenuItem.ForeColor = Color.Black;
        }
    }
}
