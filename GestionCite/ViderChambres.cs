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
    public partial class ViderChambres : DevExpress.XtraEditors.XtraUserControl
    {
        GestionCiteDataSet ds = new GestionCiteDataSet();
        InscriptionTableAdapter dt = new InscriptionTableAdapter();

        public ViderChambres()
        {
            InitializeComponent();
            dt.Fill(ds.Inscription);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Voulez-vous vraiment vider toutes les chambres?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                try
                {
                    dt.ViderChambres();
                    dt.Update(ds.Inscription);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }
    }
}
