using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GestionCite
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionCiteDataSet.Utilisateur' table. You can move, or remove it, as needed.
            this.utilisateurTableAdapter.Fill(this.gestionCiteDataSet.Utilisateur);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool b = false;
            foreach (DataRow row in this.gestionCiteDataSet.Utilisateur)
            {
                if(row[1].ToString() == usernameTextEdit.Text && row[2].ToString() == passwordTextEdit.Text)
                {
                    b = true;
                }
            }

            if (b)
            {
                Accueil accueil = new Accueil();
                Hide();
                accueil.Show();
            }
            else
            {
                XtraMessageBox.Show("L'authentification a échoué!");
            }
        }
    }
}