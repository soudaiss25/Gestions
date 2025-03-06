using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using Gestions.Views;

namespace Gestions
{
    public partial class Form2 : Form
    {
        public string profil;
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrer le form
            this.Size = new Size(800, 500);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            if (profil == "Admin")
            {
                parametresToolStripMenuItem.Visible = false;
            }
            else if(profil == "Gestionnaire")
            {
                securiteToolStripMenuItem.Visible = false;
            }
            

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

        private void appartementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAppartement fmAppartement = new fmAppartement();
            fmAppartement.Show();
            fmAppartement.MdiParent = this;
            fmAppartement.WindowState = FormWindowState.Maximized;
        }

        private void locataireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmLocataire fmLocataire = new fmLocataire();
            fmLocataire.Show();
            fmLocataire.MdiParent= this;
            fmLocataire.WindowState= FormWindowState.Maximized;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            frmUtilisateur f = new frmUtilisateur();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;

        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Afficher un message de confirmation
            DialogResult result = MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Ouvrir Form1 (page de connexion)
                Form1 form1 = new Form1();
                form1.Show();

                // Fermer Form2 (l'interface actuelle)
                this.Close();
            }
        }
    }
}
