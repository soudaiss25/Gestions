using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestions.Models;

namespace Gestions
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CreateAdmin();
            Application.Run(new Form1());
        }
        static void CreateAdmin()
        {
            Dbgestionscontext db = new Dbgestionscontext();
            var admin = db.admins.FirstOrDefault();
            if (admin == null)
            {
                admin = new Admin();
                admin.Prenom = "Administrateur";
                admin.Nom = "Admiistrateur";
                admin.identifiant = "admin";
                admin.Telephonehone = "774675793";
                admin.MotDePasse = null;
                admin.Email = "selfayadine92@gmail.com";
                db.admins.Add(admin);
                db.SaveChanges();
            }
        }
    }
}
