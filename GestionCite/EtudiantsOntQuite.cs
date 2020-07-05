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
    public partial class EtudiantsOntQuite : DevExpress.XtraEditors.XtraUserControl
    {
        public EtudiantsOntQuite()
        {
            InitializeComponent();
        }

        private void etudiantsQuitteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.etudiantsQuitteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCiteDataSet);

        }

        private void EtudiantsOntQuite_Load(object sender, EventArgs e)
        {
            refrech();

            chambreLabel1.DataBindings.Add(new Binding("Text", this.inscriptionBindingSource, "numeroChambre", true));
            pavionLabel1.DataBindings.Add(new Binding("Text", this.inscriptionBindingSource, "pavion", true));
            nomLabel1.DataBindings.Add(new Binding("Text", this.inscriptionBindingSource, "nom", true));
            prenomLabel1.DataBindings.Add(new Binding("Text", this.inscriptionBindingSource, "prenom", true));
            cINLabel1.DataBindings.Add(new Binding("Text", this.inscriptionBindingSource, "CIN", true));
            cNELabel1.DataBindings.Add(new Binding("Text", this.inscriptionBindingSource, "CNE", true));
            dateNaissanceLabel1.DataBindings.Add(new Binding("Text", this.inscriptionBindingSource, "dateNaissance", true));
            villeLabel1.DataBindings.Add(new Binding("Text", this.inscriptionBindingSource, "ville", true));
            etablissementLabel1.DataBindings.Add(new Binding("Text", this.inscriptionBindingSource, "etablissement", true));
            niveauLabel1.DataBindings.Add(new Binding("Text", this.inscriptionBindingSource, "niveau1", true));
            departementLabel1.DataBindings.Add(new Binding("Text", this.inscriptionBindingSource, "departement", true));
            photoPictureEdit.DataBindings.Add(new Binding("EditValue", this.inscriptionBindingSource, "photo", true));


            etudiantsQuitteGridControl.DataSource = gestionCiteDataSet.EtudiantsQuitte;
            datequitteDateEdit.DateTime = DateTime.Now;

            gridView1.Columns[0].Visible = false;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.FindFilterText = textEdit1.Text;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            groupControl1.Visible = true;
            simpleButton3.Visible = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            datequitteDateEdit.DateTime = DateTime.Now;
            simpleButton3.Visible = true;
            groupControl1.Visible = false;
        }

        public void refrech()
        {
            etudiantsQuitteTableAdapter.FillByInfo(gestionCiteDataSet.EtudiantsQuitte);
            inscriptionTableAdapter.FillByDistinctNotNullCh(gestionCiteDataSet.Inscription);

            //etudiantsQuitteGridControl.DataSource = null;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? dt = datequitteDateEdit.DateTime;
                int? numD = (int)numDossierComboBox.SelectedValue;
                etudiantsQuitteTableAdapter.Insert(dt, numD);

                this.Validate();
                this.etudiantsQuitteBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gestionCiteDataSet);

                refrech();
                XtraMessageBox.Show("Quitter avec succès,");
                simpleButton3.Visible = true;
                groupControl1.Visible = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : " + ex.Message);
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
