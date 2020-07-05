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
    public partial class ListFinal : DevExpress.XtraEditors.XtraUserControl
    {
        public ListFinal()
        {
            InitializeComponent();
        }

        private void ListFinal_Load(object sender, EventArgs e)
        {
            this.dateAnneeInscriptionTableAdapter.Fill(this.gestionCiteDataSet.DateAnneeInscription);

            dateAnneeInsComboBox.SelectedIndex = dateAnneeInsComboBox.Items.Count - 1;

            refrech();
        }

        public void refrech()
        {
            try
            {
                if (dateAnneeInsComboBox.SelectedValue != null)
                {
                    this.listFinalByAnneeTableAdapter.Fill(this.gestionCiteDataSet.ListFinalByAnnee, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateAnneeInsComboBox.SelectedValue, typeof(System.DateTime))))));
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void dateAnneeInsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrech();
        }

        private void dateAnneeInscriptionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dateAnneeInscriptionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCiteDataSet);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string dt = DateTime.Parse(dateAnneeInsComboBox.SelectedValue.ToString()).ToShortDateString();
            ((Accueil)this.Parent.Parent).imprimer1.submit(dt);
            ((Accueil)this.Parent.Parent).reportviwer();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                refrech();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}
