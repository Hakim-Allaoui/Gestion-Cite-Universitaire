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
using System.Data.SqlClient;
using GestionCite.GestionCiteDataSetTableAdapters;

namespace GestionCite
{
    public partial class Reinscription : DevExpress.XtraEditors.XtraUserControl
    {
        public Reinscription()
        {
            InitializeComponent();
        }

        public void updateinscr()
        {
            this.Validate();
            this.inscriptionBindingSource.EndEdit();
            this.inscriptionTableAdapter.Update(this.gestionCiteDataSet.Inscription);

        }

        private void Reinscription_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionCiteDataSet.Etudiant' table. You can move, or remove it, as needed.
            this.etudiantTableAdapter.Fill(this.gestionCiteDataSet.Etudiant);
            // TODO: This line of code loads data into the 'gestionCiteDataSet.Etudiant' table. You can move, or remove it, as needed.
            this.inscriptionTableAdapter.Fill(this.gestionCiteDataSet.Inscription);
            // TODO: This line of code loads data into the 'gestionCiteDataSet.Etudiant' table. You can move, or remove it, as needed.
            this.dateAnneeInscriptionTableAdapter.Fill(this.gestionCiteDataSet.DateAnneeInscription);
            
            this.chambreTableAdapter.FillByChPav(this.gestionCiteDataSet.Chambre);

            chambreComboBox.DisplayMember = "chPav";

            inscriptionBindingSource.AddNew();

            existplace();

            dateInscriptionDateEdit.DateTime = DateTime.Now;
            dateAnneeInsComboBox.SelectedIndex = dateAnneeInsComboBox.Items.Count - 1;
        }

        public void existplace()
        {
            bool? exist = false;
            QueriesTableAdapter qr = new QueriesTableAdapter();
            qr.IsExistPlace((int?)chambreComboBox.SelectedValue, ref exist);

            if (!(bool)exist)
            {
                labelControl1.Visible = true;
            }
            else
            {
                labelControl1.Visible = false;
            }
        }

        public void refrech()
        {
            this.etudiantTableAdapter.Fill(this.gestionCiteDataSet.Etudiant);
            // TODO: This line of code loads data into the 'gestionCiteDataSet.Etudiant' table. You can move, or remove it, as needed.
            this.inscriptionTableAdapter.Fill(this.gestionCiteDataSet.Inscription);
            // TODO: This line of code loads data into the 'gestionCiteDataSet.Etudiant' table. You can move, or remove it, as needed.
            this.dateAnneeInscriptionTableAdapter.Fill(this.gestionCiteDataSet.DateAnneeInscription);

            this.chambreTableAdapter.FillByChPav(this.gestionCiteDataSet.Chambre);

            chambreComboBox.DisplayMember = "chPav";

            inscriptionBindingSource.AddNew();

            existplace();

            dateInscriptionDateEdit.DateTime = DateTime.Now;
            dateAnneeInsComboBox.SelectedIndex = dateAnneeInsComboBox.Items.Count - 1;
        }

        public void fillEtudiant()
        {
            annuler();
            this.etudiantTableAdapter.Fill(this.gestionCiteDataSet.Etudiant);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            int? nbinsc = inscriptionTableAdapter.nbInsc((int?)numDossierComboBox.SelectedValue);

            if (nbinsc < 3)
            {
                groupControl1.Enabled = false;
                groupControl2.Enabled = true;
                simpleButton2.Visible = true;
                simpleButton3.Visible = true;
                simpleButton1.Enabled = false;
                if (numDossierComboBox.SelectedValue != null)
                {
                    numDossierLabel2.Text = numDossierComboBox.SelectedValue.ToString();
                }
            }
            else
            {
                DialogResult dr = XtraMessageBox.Show("l'étudiant s'est inscrit 3 fois. Voulez-vous continuer?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    groupControl1.Enabled = false;
                    groupControl2.Enabled = true;
                    simpleButton2.Visible = true;
                    simpleButton3.Visible = true;
                    simpleButton1.Enabled = false;
                    if (numDossierComboBox.SelectedValue != null)
                    {
                        numDossierLabel2.Text = numDossierComboBox.SelectedValue.ToString();
                    }
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (numDossierLabel2.Text != "")
            {
                try
                {
                    inscriptionTableAdapter.Insert(
                        dateInscriptionDateEdit.DateTime,
                        DateTime.Parse(dateAnneeInsComboBox.SelectedValue.ToString()),
                        numCotisationTextEdit.Text,
                        int.Parse(numDossierLabel2.Text),
                        int.Parse(chambreComboBox.SelectedValue.ToString()),
                        niveauTextEdit.Text
                        );
                    updateinscr();
                    groupControl2.Enabled = false;
                    groupControl1.Enabled = true;
                    simpleButton2.Visible = false;
                    simpleButton3.Visible = false;
                    simpleButton1.Enabled = true;

                    XtraMessageBox.Show("Réinscription réussie");
                    existplace();
                }
                catch (SqlException ex)
                {
                    XtraMessageBox.Show("Erreur : " + ex.Message);
                }
                finally
                {
                    inscriptionBindingSource.CancelEdit();
                    if (numDossierComboBox.SelectedValue != null)
                    {
                        numDossierLabel2.Text = numDossierComboBox.SelectedValue.ToString();
                    }
                }
            }
        }

        private void numDossierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numDossierComboBox.SelectedValue != null)
            {
                numDossierLabel2.Text = numDossierComboBox.SelectedValue.ToString();
            }
        }
        public void annuler()
        {
            inscriptionBindingSource.CancelEdit();
            groupControl2.Enabled = false;
            groupControl1.Enabled = true;
            simpleButton2.Visible = false;
            simpleButton3.Visible = false;
            simpleButton1.Enabled = true;
            if (numDossierComboBox.SelectedValue != null)
            {
                numDossierLabel2.Text = numDossierComboBox.SelectedValue.ToString();
            }
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            annuler();
        }

        private void chambreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            existplace();
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
