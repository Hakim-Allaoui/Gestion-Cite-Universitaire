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
using GestionCite.GestionCiteDataSetTableAdapters;

namespace GestionCite
{
    public partial class NouvelleInscription : DevExpress.XtraEditors.XtraUserControl
    {
        public NouvelleInscription()
        {
            InitializeComponent();
        }

        public void updateEtudiant()
        {
            this.Validate();
            this.etudiantBindingSource.EndEdit();
            this.etudiantTableAdapter.Update(this.gestionCiteDataSet.Etudiant);
        }

        public void updateInscription()
        {
            this.Validate();
            this.inscriptionBindingSource.EndEdit();
            this.inscriptionTableAdapter.Update(this.gestionCiteDataSet.Inscription);
            this.inscriptionTableAdapter.Fill(this.gestionCiteDataSet.Inscription);
        }


        public void Adnew()
        {
            etudiantBindingSource.AddNew();
            inscriptionBindingSource.AddNew();
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (numDossierTextEdit.Text != "")
            {
                bool? b = false;
                etudiantTableAdapter.IsExistDossier(int.Parse(numDossierTextEdit.Text), ref b);
                if (!(bool)b)
                {
                    int i = 0;
                    try
                    {

                        if (dateInscriptionDateEdit.DateTime >= ((DateTime)dateAnneeInsComboBox.SelectedValue).Date && dateInscriptionDateEdit.DateTime < ((DateTime)dateAnneeInsComboBox.SelectedValue).Date.AddYears(1))
                        {
                            ImageConverter imgConverter = new ImageConverter();
                            byte[] photo = (byte[])imgConverter.ConvertTo(photoPictureEdit.Image, typeof(byte[]));

                            etudiantTableAdapter.Insert(
                                int.Parse(numDossierTextEdit.Text),
                                nomTextEdit.Text,
                                prenomTextEdit.Text,
                                cINTextEdit.Text,
                                cNETextEdit.Text,
                                dateNaissanceDateEdit.DateTime,
                                villeTextEdit.Text,
                                etablissementTextEdit.Text,
                                niveauTextEdit.Text,
                                departementTextEdit.Text,
                                photo
                                );

                            updateEtudiant();
                            i++;

                            inscriptionTableAdapter.Insert(
                                dateInscriptionDateEdit.DateTime,
                                DateTime.Parse(dateAnneeInsComboBox.SelectedValue.ToString()),
                                numCotisationTextEdit.Text,
                                int.Parse(numDossierTextEdit.Text),
                                int.Parse(chambreComboBox1.SelectedValue.ToString()),
                                niveauTextEdit.Text
                                );

                            updateInscription();
                            XtraMessageBox.Show("Etudiant Bien Inscrit");
                        }
                        else
                        {
                            XtraMessageBox.Show("La date inscription doit appartient à l'année d'inscription choisi!");
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        if(i == 0)
                        {
                            XtraMessageBox.Show("Erruer : " + ex.Message);
                        }
                        else if(i == 1)
                        {
                            XtraMessageBox.Show("Erreur dons inscription!\nEtudiant Ajouté sans Inscription!\nVous-voulez Inscrire dons la form Réinscription.");
                            etudiantBindingSource.CancelEdit();
                            inscriptionBindingSource.CancelEdit();
                        }
                        else
                        {
                            XtraMessageBox.Show("Erruer : " + ex.Message);
                        }
                    }
                    finally
                    {
                        existplace();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Etudiant exist déja .");
                }
            }
            else
            {
                XtraMessageBox.Show("Tous les champs sont obligatoires.");
            }
        }

        private void photoPictureEdit_Click(object sender, EventArgs e)
        {
            photoPictureEdit.LoadImage();
        }

        public void refrech()
        {
            this.inscriptionTableAdapter.Fill(this.gestionCiteDataSet.Inscription);
            this.chambreTableAdapter.FillByChPav(this.gestionCiteDataSet.Chambre);
            this.dateAnneeInscriptionTableAdapter.Fill(this.gestionCiteDataSet.DateAnneeInscription);

            chambreComboBox1.DisplayMember = "chPav";


            dateInscriptionDateEdit.DateTime = DateTime.Now;
            dateAnneeInsComboBox.SelectedIndex = dateAnneeInsComboBox.Items.Count - 1;

            existplace();
        }

        private void NouvelleInscription_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'gestionCiteDataSet.Etudiant' table. You can move, or remove it, as needed.
            //this.etudiantTableAdapter.Fill(this.gestionCiteDataSet.Etudiant);
            this.inscriptionTableAdapter.Fill(this.gestionCiteDataSet.Inscription);
            this.chambreTableAdapter.FillByChPav(this.gestionCiteDataSet.Chambre);
            this.dateAnneeInscriptionTableAdapter.Fill(this.gestionCiteDataSet.DateAnneeInscription);

            chambreComboBox1.DisplayMember = "chPav";


            dateInscriptionDateEdit.DateTime = DateTime.Now;
            dateAnneeInsComboBox.SelectedIndex = dateAnneeInsComboBox.Items.Count - 1;

            existplace();
        }

        private void numDossierTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public void existplace()
        {
            bool? exist = false;
            QueriesTableAdapter qr = new QueriesTableAdapter();
            qr.IsExistPlace((int?)chambreComboBox1.SelectedValue, ref exist);

            if (!(bool)exist)
            {
                labelControl1.Visible = true;
            }
            else
            {
                labelControl1.Visible = false;
            }
        }

        private void chambreComboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
