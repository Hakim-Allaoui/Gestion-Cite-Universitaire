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
    public partial class ListInscrition : DevExpress.XtraEditors.XtraUserControl
    {
        public ListInscrition()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'gestionCiteDataSet.Etudiant' table. You can move, or remove it, as needed.
            this.inscriptionTableAdapter.Fill(this.gestionCiteDataSet.Inscription);
        }

        public void refrech()
        {
            this.inscriptionTableAdapter.Fill(this.gestionCiteDataSet.Inscription);
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.FindFilterText = textEdit1.Text;
        }

        private void ListInscrition_Load(object sender, EventArgs e)
        {

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

        private void dataNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
            {
                try
                {
                    inscriptionBindingSource.EndEdit();
                    inscriptionTableAdapter.Update(gestionCiteDataSet.Inscription);
                    refrech();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erreur : " + ex.Message);
                }
            }
            if (e.Button.ButtonType == NavigatorButtonType.CancelEdit)
            {
                try
                {
                    inscriptionBindingSource.CancelEdit();
                    refrech();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erreur : " + ex.Message);
                }
            }

            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                DialogResult dr = XtraMessageBox.Show("Voulez-vous vraiment supprimer?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        inscriptionTableAdapter.Update(gestionCiteDataSet.Inscription);
                        //refrech();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Erreur : " + ex.Message);
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void gridView1_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            //gridView1.OptionsBehavior.Editable = false;
        }
    }
}
