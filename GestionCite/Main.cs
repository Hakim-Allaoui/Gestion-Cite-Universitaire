using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;

namespace GestionCite
{
    public partial class Main : DevExpress.XtraEditors.XtraUserControl
    {
        EtudiantDetails ed = new EtudiantDetails();
        string numD = "0";

        public Main()
        {
            InitializeComponent();

            ed.Parameters["numDossierPar"].Value = numD;
            ed.RequestParameters = false;
        }


        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                this.listFinalThisYearTableAdapter.Fill(this.gestionCiteDataSet.ListFinalThisYear);
            }
            catch (Exception)
            {
                //XtraMessageBox.Show("Selectionnez un etudiant!!");
            }
        }

        public void refrech()
        {
            this.listFinalThisYearTableAdapter.Fill(this.gestionCiteDataSet.ListFinalThisYear);
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.FindFilterText = textEdit1.Text;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                //MessageBox.Show(row[4].ToString());
                numD = row[4].ToString();
            }
            ed.Parameters["numDossierPar"].Value = numD;
            ed.RequestParameters = false;
            ed.CreateDocument();
            ed.ShowPreview();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in gridView1.GetSelectedRows())
                {
                    DataRow row = gridView1.GetDataRow(i);
                    //MessageBox.Show(row[4].ToString());
                    numD = row[4].ToString();
                }
                ed.Parameters["numDossierPar"].Value = numD;
                ed.RequestParameters = false;
                ed.CreateDocument();
                ed.ShowPreview();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Selectionnez un etudiant!!");
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
