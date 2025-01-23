using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestions.Models;
using Mysqlx.Session;

namespace Gestions.Views
{
    public partial class fmAppartement : Form
    {
        public fmAppartement()
        {
            InitializeComponent();
        }
        Dbgestionscontext db = new Dbgestionscontext();

        private void ResetForm()

        {

            txtAdresse.Text = string.Empty;
            txtSurface.Text = string.Empty;
            txtNombrePlace.Text = string.Empty;
            txtCapacite.Text = string.Empty;
            dgAppartement.DataSource = db.Appartements.Select(a =) ;

        }

        private void fmAppartement_Load(object sender, EventArgs e)
        {
            ResetForm();
        }


       
    }
}
