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
    public partial class ListEtudiants : DevExpress.XtraEditors.XtraUserControl
    {
        public ListEtudiants()
        {
            InitializeComponent();
        }

        private void ListEtudiants_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionCiteDataSet.Etudiant' table. You can move, or remove it, as needed.
            this.etudiantTableAdapter.Fill(this.gestionCiteDataSet.Etudiant);
        }

        public void fill()
        {
            this.etudiantTableAdapter.Fill(this.gestionCiteDataSet.Etudiant);
        }

        public void update()
        {
            this.Validate();
            this.etudiantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCiteDataSet);
        }

        private void photoPictureEdit_Click(object sender, EventArgs e)
        {
            photoPictureEdit.LoadImage();
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupControl1.Controls)
            {
                item.Enabled = true;
            }
            photoPictureEdit.Click += photoPictureEdit_Click;
            groupControl2.Visible = false;
            groupControl3.Visible = true;
            try
            {
                etudiantBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : "+ex.Message);
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            try
            {
                update();

                foreach (Control item in groupControl1.Controls)
                {
                    if (item.Name != "photoPictureEdit")
                    {
                        item.Enabled = false;
                    }
                }
                photoPictureEdit.Click -= photoPictureEdit_Click;
                groupControl3.Visible = false;
                groupControl2.Visible = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : " + ex.Message);
            }
        }
        private void simpleButton8_Click(object sender, EventArgs e)
        {
            try
            {
                if(gridView1.IsNewItemRow(gridView1.GetSelectedRows()[0])) etudiantBindingSource.RemoveCurrent();
                foreach (Control item in groupControl1.Controls)
                {
                    if (item.Name != "photoPictureEdit")
                    {
                        item.Enabled = false;
                    }
                }
                photoPictureEdit.Click -= photoPictureEdit_Click;

                groupControl3.Visible = false;
                groupControl2.Visible = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupControl1.Controls)
            {
                item.Enabled = true;
            }
            photoPictureEdit.Click += photoPictureEdit_Click;
            groupControl2.Visible = false;
            groupControl3.Visible = true;
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            etudiantBindingSource.MovePrevious();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            etudiantBindingSource.MoveNext();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Voulez-vous vraiment supprimer?","Confirmation",  MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                try
                {
                    etudiantBindingSource.RemoveCurrent();
                    update();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erreur : " + ex.Message);
                }
                finally
                {
                    etudiantBindingSource.CancelEdit();
                    //etudiantBindingSource.EndEdit();
                    this.etudiantTableAdapter.Fill(this.gestionCiteDataSet.Etudiant);
                    //etudiantGridControl.DataSource = etudiantBindingSource;
                }
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (numDossierTextEdit.Text != "")
            {
                int numDossier = int.Parse(numDossierTextEdit.Text);

                inscriptionBindingSource.Filter = "numDossier = " + numDossier.ToString();

                this.inscriptionTableAdapter.Fill(this.gestionCiteDataSet.Inscription);

                inscriptionGridControl.Visible = true;
                simpleButton6.Visible = true;
                groupControl1.Enabled = false;
                groupControl2.Visible = false;
                groupControl3.Visible = false;
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            simpleButton6.Visible = false;
            groupControl1.Enabled = true;
            groupControl2.Visible = true;
            groupControl3.Visible = true;
            inscriptionGridControl.Visible = false;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.FindFilterText = textEdit1.Text;
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                this.etudiantTableAdapter.Fill(this.gestionCiteDataSet.Etudiant);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}
