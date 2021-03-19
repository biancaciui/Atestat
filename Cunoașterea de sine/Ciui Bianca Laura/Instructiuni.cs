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
    public partial class Instructiuni : Form
    {
        public Instructiuni()
        {
            InitializeComponent();
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            //labelul de ieșire din instrucțiuni și revenire la meniul de alegere a testului
            AlegereaTestului f = new AlegereaTestului();
            f.Show();
            Hide();
        }

        //instrucțiuni care țin de estetică
        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
        }
    }
}
