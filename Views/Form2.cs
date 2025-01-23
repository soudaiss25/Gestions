using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestions
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void proprietaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmProprietaire fmProprietaire = new FmProprietaire();
            fmProprietaire.Show();
            fmProprietaire.MdiParent = this;
            fmProprietaire.WindowState = FormWindowState.Maximized;

        }
    }
}
