using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace GestionCite
{
    public partial class Imprimer : DevExpress.XtraEditors.XtraUserControl
    {
        public string dt = DateTime.Now.ToShortDateString();
        ListFinalReport lfr = new ListFinalReport();

        public Imprimer()
        {
            InitializeComponent();

            lfr.Parameters["dateAnnee"].Value = dt;
            lfr.RequestParameters = false;
            documentViewer1.DocumentSource = lfr;
        }

        public void submit(string date)
        {
            lfr = new ListFinalReport();
            lfr.Parameters["dateAnnee"].Value = date;
            lfr.RequestParameters = false;
            documentViewer1.DocumentSource = lfr;
            lfr.CreateDocument();
        }

        private void sub(object sender, ParametersRequestEventArgs e)
        {
            
        }

        private void Imprimer_Load(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            lfr.ShowPreview();
        }
    }
}
