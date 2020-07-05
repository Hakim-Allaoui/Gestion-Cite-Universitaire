using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionCite
{
    public partial class Accueil : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            foreach (XtraUserControl item in fluentDesignFormContainer1.Controls.OfType<XtraUserControl>())
            {
                if (item.Name == "main1")
                {
                    item.Dock = DockStyle.Fill;
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            foreach (XtraUserControl item in fluentDesignFormContainer1.Controls.OfType<XtraUserControl>())
            {
                if (item.Name == "main1")
                {
                    item.Dock = DockStyle.Fill;
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            try
            {
                listEtudiants1.fill();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : " + ex.Message);
            }
            foreach (XtraUserControl item in fluentDesignFormContainer1.Controls.OfType<XtraUserControl>())
            {
                if (item.Name == "listEtudiants1")
                {
                    item.Dock = DockStyle.Fill;
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            try
            {
                listInscrition1.refrech();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : " + ex.Message);
            }
            foreach (XtraUserControl item in fluentDesignFormContainer1.Controls.OfType<XtraUserControl>())
            {
                if (item.Name == "listInscrition1")
                {
                    item.Dock = DockStyle.Fill;
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            foreach (XtraUserControl item in fluentDesignFormContainer1.Controls.OfType<XtraUserControl>())
            {
                if (item.Name == "nouvelleInscription1")
                {
                    item.Dock = DockStyle.Fill;
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            try
            {
                etudiantsOntQuite1.refrech();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : " + ex.Message);
            }

            foreach (XtraUserControl item in fluentDesignFormContainer1.Controls.OfType<XtraUserControl>())
            {
                if (item.Name == "etudiantsOntQuite1")
                {
                    item.Dock = DockStyle.Fill;
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            try
            {
                gestionPavEtChambres1.refrech();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : " + ex.Message);
            }

            foreach (XtraUserControl item in fluentDesignFormContainer1.Controls.OfType<XtraUserControl>())
            {
                if (item.Name == "gestionPavEtChambres1")
                {
                    item.Dock = DockStyle.Fill;
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            try
            {
                gestionUtilisateurs1.refrech();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : " + ex.Message);
            }

            foreach (XtraUserControl item in fluentDesignFormContainer1.Controls.OfType<XtraUserControl>())
            {
                if (item.Name == "gestionUtilisateurs1")
                {
                    item.Dock = DockStyle.Fill;
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            foreach (XtraUserControl item in fluentDesignFormContainer1.Controls.OfType<XtraUserControl>())
            {
                if (item.Name == "villesChart1")
                {
                    item.Dock = DockStyle.Fill;
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            try
            {
                reinscription1.fillEtudiant();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : " + ex.Message);
            }
            foreach (XtraUserControl item in fluentDesignFormContainer1.Controls.OfType<XtraUserControl>())
            {
                if (item.Name == "reinscription1")
                {
                    item.Dock = DockStyle.Fill;
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        private void accordionControlElement15_Click(object sender, EventArgs e)
        {
            try
            {
                listFinal1.refrech();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : " + ex.Message);
            }
            foreach (XtraUserControl item in fluentDesignFormContainer1.Controls.OfType<XtraUserControl>())
            {
                if (item.Name == "listFinal1")
                {
                    item.Dock = DockStyle.Fill;
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        public void reportviwer()
        {
            /*try
            {
                reinscription1.fillEtudiant();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : " + ex.Message);
            }*/
            foreach (XtraUserControl item in fluentDesignFormContainer1.Controls.OfType<XtraUserControl>())
            {

                if (item.Name == "imprimer1")
                {
                    item.Dock = DockStyle.Fill;
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        private void Accueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            /*try
            {
                reinscription1.fillEtudiant();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : " + ex.Message);
            }*/
            foreach (XtraUserControl item in fluentDesignFormContainer1.Controls.OfType<XtraUserControl>())
            {

                if (item.Name == "gestionDateAnnee1")
                {
                    item.Dock = DockStyle.Fill;
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        private void accordionControlElement16_Click(object sender, EventArgs e)
        {
            /*try
            {
                reinscription1.fillEtudiant();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur : " + ex.Message);
            }*/
            foreach (XtraUserControl item in fluentDesignFormContainer1.Controls.OfType<XtraUserControl>())
            {

                if (item.Name == "viderChambres1")
                {
                    item.Dock = DockStyle.Fill;
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }
    }
}
