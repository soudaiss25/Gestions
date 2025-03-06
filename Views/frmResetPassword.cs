using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestions.Models;
using Gestions.utils;

namespace Gestions.Views
{
    public partial class frmResetPassword : Form
    {
       public int idUser;
        public frmResetPassword()
        {
            InitializeComponent();
        }
        Dbgestionscontext db = new Dbgestionscontext();
        private void txtMotDePasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (txtIdentifiant.Text == txtMotDePasse.Text)
            {
                var leuser = db.Users.Find(idUser);
                if (leuser != null)
                {
                    using (MD5 md5Hash = MD5.Create())
                    {
                        string newPasswordHash = CryptApp.GetMd5Hash(md5Hash, txtMotDePasse.Text);
                        MessageBox.Show("Nouveau hash généré : " + newPasswordHash); // Vérification

                        leuser.MotDePasse = newPasswordHash;
                        leuser.status = "Enabled";
                        db.SaveChanges();
                    }
                    MessageBox.Show("Mot de passe mis à jour !");
                    Form2 f = new Form2();
                    f.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Utilisateur introuvable !");
                }
            }
            else
            {
                MessageBox.Show("Les mots de passe ne sont pas identiques !");
            }
        }

        private void frmResetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
