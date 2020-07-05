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
    public partial class GestionUtilisateurs : DevExpress.XtraEditors.XtraUserControl
    {
        public GestionUtilisateurs()
        {
            InitializeComponent();
            refrech();

        }

        private void GestionUtilisateurs_Load(object sender, EventArgs e)
        {

        }

        public void refrech()
        {
            utilisateurTableAdapter.FillWithoutAdmin(gestionCiteDataSet.Utilisateur);
        }

        private void utilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.utilisateurBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gestionCiteDataSet);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : " + ex.Message);
            }

        }

        private void fillWithoutAdminToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.utilisateurTableAdapter.FillWithoutAdmin(this.gestionCiteDataSet.Utilisateur);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
