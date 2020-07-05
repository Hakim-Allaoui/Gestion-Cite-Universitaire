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
    public partial class GestionPavEtChambres : DevExpress.XtraEditors.XtraUserControl
    {
        public GestionPavEtChambres()
        {
            InitializeComponent();
        }

        public void update()
        {
            this.Validate();
            this.chambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCiteDataSet);
        }

        public void refrech()
        {
            this.chambreTableAdapter.Fill(gestionCiteDataSet.Chambre);
        }

        private void GestionPavEtChambres_Load(object sender, EventArgs e)
        {
            refrech();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                update();

                simpleButton1.Visible = false;
                simpleButton2.Visible = false;
                groupControl2.Enabled = true;
                chambreGridControl.Enabled = true;
                numeroChambreSpinEdit.Enabled = false;
                pavionTextEdit.Enabled = false;
                nbPlacesSpinEdit.Enabled = false;
                refrech();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : " + ex.Message);
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                chambreBindingSource.CancelEdit();
                simpleButton1.Visible = false;
                simpleButton2.Visible = false;
                groupControl2.Enabled = true;
                chambreGridControl.Enabled = true;
                numeroChambreSpinEdit.Enabled = false;
                pavionTextEdit.Enabled = false;
                nbPlacesSpinEdit.Enabled = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                refrech();
            }
        }


        private void simpleButton3_Click(object sender, EventArgs e)
        {
            simpleButton1.Visible = true;
            simpleButton2.Visible = true;
            groupControl2.Enabled = false;
            chambreGridControl.Enabled = false;
            numeroChambreSpinEdit.Enabled = true;
            pavionTextEdit.Enabled = true;
            nbPlacesSpinEdit.Enabled = true;
            chambreBindingSource.AddNew();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            simpleButton1.Visible = true;
            simpleButton2.Visible = true;
            groupControl2.Enabled = false;
            chambreGridControl.Enabled = false;
            numeroChambreSpinEdit.Enabled = true;
            pavionTextEdit.Enabled = true;
            nbPlacesSpinEdit.Enabled = true;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Voulez-vous vraiment supprimer?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                try
                {
                    chambreBindingSource.RemoveCurrent();
                    update();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erreur : " + ex.Message);
                }
                finally
                {
                    refrech();
                }
            }
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
