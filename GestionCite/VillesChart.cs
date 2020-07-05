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
    public partial class VillesChart : DevExpress.XtraEditors.XtraUserControl
    {
        public VillesChart()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'gestionCiteDataSet.Etudiant' table. You can move, or remove it, as needed.
            this.etudiantTableAdapter.Fill(this.gestionCiteDataSet.Etudiant);
            chartControl1.Show();
        }

        private void VillesChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionCiteDataSet.Etudiant' table. You can move, or remove it, as needed.
            this.etudiantTableAdapter.Fill(this.gestionCiteDataSet.Etudiant);
        }

        private void etudiantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.etudiantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCiteDataSet);

        }
    }
}
