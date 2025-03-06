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
using Gestions.Report;

namespace Gestions.Views
{
    public partial class FrmPrintListeProprietaire : Form
    {
        public FrmPrintListeProprietaire()
        {
            InitializeComponent();
        }
        Dbgestionscontext db = new Dbgestionscontext();
        private void FrmPrintListeProprietaire_Load(object sender, EventArgs e)
        {
            rptListProprietaire objRpt = new rptListProprietaire();
            objRpt.SetDataSource(GetTableProprietaire());
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();

        }
        public DataTable GetTableProprietaire()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Ninea", typeof(string));
            table.Columns.Add("prenom", typeof(string));
            table.Columns.Add("Nom", typeof(string));
            table.Columns.Add("Telephone", typeof(string));
            table.Columns.Add("Email", typeof(string));

            var App = db.Proprietaires.ToList();
            foreach (var i in App)
            {
                table.Rows.Add(i.Ninea, i.Prenom, i.Nom, i.Telephonehone, i.Email);
            }

            return table;
        }
    }
}
