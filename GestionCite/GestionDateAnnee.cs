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

namespace GestionCite
{
    public partial class GestionDateAnnee : DevExpress.XtraEditors.XtraUserControl
    {
        public GestionDateAnnee()
        {
            InitializeComponent();
        }

        private void dateAnneeInscriptionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dateAnneeInscriptionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCiteDataSet);

        }

        private void GestionDateAnnee_Load(object sender, EventArgs e)
        {
            this.dateAnneeInscriptionTableAdapter.Fill(this.gestionCiteDataSet.DateAnneeInscription);
        }
    }
}
