namespace GestionCite
{
    partial class ListFinal
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dateAnneeInsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListFinal));
            this.dateAnneeInsComboBox = new System.Windows.Forms.ComboBox();
            this.dateAnneeInscriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionCiteDataSet = new GestionCite.GestionCiteDataSet();
            this.dateAnneeInscriptionTableAdapter = new GestionCite.GestionCiteDataSetTableAdapters.DateAnneeInscriptionTableAdapter();
            this.tableAdapterManager = new GestionCite.GestionCiteDataSetTableAdapters.TableAdapterManager();
            this.listFinalByAnneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listFinalByAnneeTableAdapter = new GestionCite.GestionCiteDataSetTableAdapters.ListFinalByAnneeTableAdapter();
            this.listFinalByAnneeGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrenom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNDossier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNaissance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVille = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEtablissement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNiveau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChambre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPavion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            dateAnneeInsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dateAnneeInscriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCiteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listFinalByAnneeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listFinalByAnneeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateAnneeInsLabel
            // 
            dateAnneeInsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            dateAnneeInsLabel.AutoSize = true;
            dateAnneeInsLabel.Location = new System.Drawing.Point(277, 38);
            dateAnneeInsLabel.Name = "dateAnneeInsLabel";
            dateAnneeInsLabel.Size = new System.Drawing.Size(137, 13);
            dateAnneeInsLabel.TabIndex = 1;
            dateAnneeInsLabel.Text = "Date Annee Ins:cripption : ";
            // 
            // dateAnneeInsComboBox
            // 
            this.dateAnneeInsComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateAnneeInsComboBox.DataSource = this.dateAnneeInscriptionBindingSource;
            this.dateAnneeInsComboBox.DisplayMember = "dateAnneeIns";
            this.dateAnneeInsComboBox.FormattingEnabled = true;
            this.dateAnneeInsComboBox.Location = new System.Drawing.Point(420, 35);
            this.dateAnneeInsComboBox.Name = "dateAnneeInsComboBox";
            this.dateAnneeInsComboBox.Size = new System.Drawing.Size(198, 21);
            this.dateAnneeInsComboBox.TabIndex = 3;
            this.dateAnneeInsComboBox.ValueMember = "dateAnneeIns";
            this.dateAnneeInsComboBox.SelectedIndexChanged += new System.EventHandler(this.dateAnneeInsComboBox_SelectedIndexChanged);
            // 
            // dateAnneeInscriptionBindingSource
            // 
            this.dateAnneeInscriptionBindingSource.DataMember = "DateAnneeInscription";
            this.dateAnneeInscriptionBindingSource.DataSource = this.gestionCiteDataSet;
            // 
            // gestionCiteDataSet
            // 
            this.gestionCiteDataSet.DataSetName = "GestionCiteDataSet";
            this.gestionCiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateAnneeInscriptionTableAdapter
            // 
            this.dateAnneeInscriptionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.DateAnneeInscriptionTableAdapter = this.dateAnneeInscriptionTableAdapter;
            this.tableAdapterManager.EtudiantsQuitteTableAdapter = null;
            this.tableAdapterManager.EtudiantTableAdapter = null;
            this.tableAdapterManager.InscriptionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionCite.GestionCiteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // listFinalByAnneeBindingSource
            // 
            this.listFinalByAnneeBindingSource.DataMember = "ListFinalByAnnee";
            this.listFinalByAnneeBindingSource.DataSource = this.gestionCiteDataSet;
            // 
            // listFinalByAnneeTableAdapter
            // 
            this.listFinalByAnneeTableAdapter.ClearBeforeFill = true;
            // 
            // listFinalByAnneeGridControl
            // 
            this.listFinalByAnneeGridControl.DataSource = this.listFinalByAnneeBindingSource;
            this.listFinalByAnneeGridControl.Location = new System.Drawing.Point(3, 130);
            this.listFinalByAnneeGridControl.MainView = this.gridView1;
            this.listFinalByAnneeGridControl.Name = "listFinalByAnneeGridControl";
            this.listFinalByAnneeGridControl.Size = new System.Drawing.Size(914, 507);
            this.listFinalByAnneeGridControl.TabIndex = 4;
            this.listFinalByAnneeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNom,
            this.colPrenom,
            this.colCIN,
            this.colCNE,
            this.colNDossier,
            this.colNaissance,
            this.colVille,
            this.colEtablissement,
            this.colNiveau,
            this.colDepartement,
            this.colChambre,
            this.colPavion});
            this.gridView1.GridControl = this.listFinalByAnneeGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colNom
            // 
            this.colNom.AppearanceCell.Options.UseTextOptions = true;
            this.colNom.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNom.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNom.AppearanceHeader.Options.UseTextOptions = true;
            this.colNom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNom.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNom.FieldName = "Nom";
            this.colNom.Name = "colNom";
            this.colNom.Visible = true;
            this.colNom.VisibleIndex = 0;
            // 
            // colPrenom
            // 
            this.colPrenom.AppearanceCell.Options.UseTextOptions = true;
            this.colPrenom.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrenom.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPrenom.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrenom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrenom.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPrenom.FieldName = "Prenom";
            this.colPrenom.Name = "colPrenom";
            this.colPrenom.Visible = true;
            this.colPrenom.VisibleIndex = 1;
            // 
            // colCIN
            // 
            this.colCIN.AppearanceCell.Options.UseTextOptions = true;
            this.colCIN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCIN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCIN.AppearanceHeader.Options.UseTextOptions = true;
            this.colCIN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCIN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCIN.FieldName = "CIN";
            this.colCIN.Name = "colCIN";
            this.colCIN.Visible = true;
            this.colCIN.VisibleIndex = 2;
            // 
            // colCNE
            // 
            this.colCNE.AppearanceCell.Options.UseTextOptions = true;
            this.colCNE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCNE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCNE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCNE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCNE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCNE.FieldName = "CNE";
            this.colCNE.Name = "colCNE";
            this.colCNE.Visible = true;
            this.colCNE.VisibleIndex = 3;
            // 
            // colNDossier
            // 
            this.colNDossier.AppearanceCell.Options.UseTextOptions = true;
            this.colNDossier.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNDossier.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNDossier.AppearanceHeader.Options.UseTextOptions = true;
            this.colNDossier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNDossier.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNDossier.FieldName = "N Dossier";
            this.colNDossier.Name = "colNDossier";
            this.colNDossier.Visible = true;
            this.colNDossier.VisibleIndex = 4;
            // 
            // colNaissance
            // 
            this.colNaissance.AppearanceCell.Options.UseTextOptions = true;
            this.colNaissance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNaissance.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNaissance.AppearanceHeader.Options.UseTextOptions = true;
            this.colNaissance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNaissance.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNaissance.FieldName = "Naissance";
            this.colNaissance.Name = "colNaissance";
            this.colNaissance.Visible = true;
            this.colNaissance.VisibleIndex = 5;
            // 
            // colVille
            // 
            this.colVille.AppearanceCell.Options.UseTextOptions = true;
            this.colVille.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVille.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colVille.AppearanceHeader.Options.UseTextOptions = true;
            this.colVille.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVille.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colVille.FieldName = "Ville";
            this.colVille.Name = "colVille";
            this.colVille.Visible = true;
            this.colVille.VisibleIndex = 6;
            // 
            // colEtablissement
            // 
            this.colEtablissement.AppearanceCell.Options.UseTextOptions = true;
            this.colEtablissement.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEtablissement.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEtablissement.AppearanceHeader.Options.UseTextOptions = true;
            this.colEtablissement.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEtablissement.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEtablissement.FieldName = "Etablissement";
            this.colEtablissement.Name = "colEtablissement";
            this.colEtablissement.Visible = true;
            this.colEtablissement.VisibleIndex = 7;
            // 
            // colNiveau
            // 
            this.colNiveau.AppearanceCell.Options.UseTextOptions = true;
            this.colNiveau.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNiveau.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNiveau.AppearanceHeader.Options.UseTextOptions = true;
            this.colNiveau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNiveau.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNiveau.FieldName = "Niveau";
            this.colNiveau.Name = "colNiveau";
            this.colNiveau.Visible = true;
            this.colNiveau.VisibleIndex = 8;
            // 
            // colDepartement
            // 
            this.colDepartement.AppearanceCell.Options.UseTextOptions = true;
            this.colDepartement.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDepartement.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDepartement.AppearanceHeader.Options.UseTextOptions = true;
            this.colDepartement.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDepartement.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDepartement.FieldName = "Departement";
            this.colDepartement.Name = "colDepartement";
            this.colDepartement.Visible = true;
            this.colDepartement.VisibleIndex = 9;
            // 
            // colChambre
            // 
            this.colChambre.AppearanceCell.Options.UseTextOptions = true;
            this.colChambre.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChambre.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colChambre.AppearanceHeader.Options.UseTextOptions = true;
            this.colChambre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChambre.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colChambre.FieldName = "Chambre";
            this.colChambre.Name = "colChambre";
            this.colChambre.Visible = true;
            this.colChambre.VisibleIndex = 10;
            // 
            // colPavion
            // 
            this.colPavion.AppearanceCell.Options.UseTextOptions = true;
            this.colPavion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPavion.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPavion.AppearanceHeader.Options.UseTextOptions = true;
            this.colPavion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPavion.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPavion.FieldName = "Pavion";
            this.colPavion.Name = "colPavion";
            this.colPavion.Visible = true;
            this.colPavion.VisibleIndex = 11;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton1.Location = new System.Drawing.Point(802, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(115, 53);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Imprimer";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(886, 62);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(31, 31);
            this.pictureEdit1.TabIndex = 27;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // ListFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.listFinalByAnneeGridControl);
            this.Controls.Add(this.dateAnneeInsComboBox);
            this.Controls.Add(dateAnneeInsLabel);
            this.Name = "ListFinal";
            this.Size = new System.Drawing.Size(920, 640);
            this.Load += new System.EventHandler(this.ListFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateAnneeInscriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCiteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listFinalByAnneeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listFinalByAnneeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox dateAnneeInsComboBox;
        private GestionCiteDataSet gestionCiteDataSet;
        private System.Windows.Forms.BindingSource dateAnneeInscriptionBindingSource;
        private GestionCiteDataSetTableAdapters.DateAnneeInscriptionTableAdapter dateAnneeInscriptionTableAdapter;
        private GestionCiteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource listFinalByAnneeBindingSource;
        private GestionCiteDataSetTableAdapters.ListFinalByAnneeTableAdapter listFinalByAnneeTableAdapter;
        private DevExpress.XtraGrid.GridControl listFinalByAnneeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNom;
        private DevExpress.XtraGrid.Columns.GridColumn colPrenom;
        private DevExpress.XtraGrid.Columns.GridColumn colCIN;
        private DevExpress.XtraGrid.Columns.GridColumn colCNE;
        private DevExpress.XtraGrid.Columns.GridColumn colNDossier;
        private DevExpress.XtraGrid.Columns.GridColumn colNaissance;
        private DevExpress.XtraGrid.Columns.GridColumn colVille;
        private DevExpress.XtraGrid.Columns.GridColumn colEtablissement;
        private DevExpress.XtraGrid.Columns.GridColumn colNiveau;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartement;
        private DevExpress.XtraGrid.Columns.GridColumn colChambre;
        private DevExpress.XtraGrid.Columns.GridColumn colPavion;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
