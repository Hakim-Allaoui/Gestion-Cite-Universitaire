namespace GestionCite
{
    partial class GestionPavEtChambres
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
            System.Windows.Forms.Label numeroChambreLabel;
            System.Windows.Forms.Label pavionLabel;
            System.Windows.Forms.Label nbPlacesLabel;
            System.Windows.Forms.Label chambreIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPavEtChambres));
            this.gestionCiteDataSet = new GestionCite.GestionCiteDataSet();
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chambreTableAdapter = new GestionCite.GestionCiteDataSetTableAdapters.ChambreTableAdapter();
            this.tableAdapterManager = new GestionCite.GestionCiteDataSetTableAdapters.TableAdapterManager();
            this.chambreGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colchambreId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumeroChambre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpavion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbPlaces = new DevExpress.XtraGrid.Columns.GridColumn();
            this.numeroChambreSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.pavionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nbPlacesSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.chambreIdLabel1 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            numeroChambreLabel = new System.Windows.Forms.Label();
            pavionLabel = new System.Windows.Forms.Label();
            nbPlacesLabel = new System.Windows.Forms.Label();
            chambreIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCiteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroChambreSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPlacesSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // numeroChambreLabel
            // 
            numeroChambreLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            numeroChambreLabel.AutoSize = true;
            numeroChambreLabel.Location = new System.Drawing.Point(358, 77);
            numeroChambreLabel.Name = "numeroChambreLabel";
            numeroChambreLabel.Size = new System.Drawing.Size(93, 13);
            numeroChambreLabel.TabIndex = 3;
            numeroChambreLabel.Text = "numero Chambre:";
            // 
            // pavionLabel
            // 
            pavionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pavionLabel.AutoSize = true;
            pavionLabel.Location = new System.Drawing.Point(405, 103);
            pavionLabel.Name = "pavionLabel";
            pavionLabel.Size = new System.Drawing.Size(43, 13);
            pavionLabel.TabIndex = 5;
            pavionLabel.Text = "pavion:";
            // 
            // nbPlacesLabel
            // 
            nbPlacesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            nbPlacesLabel.AutoSize = true;
            nbPlacesLabel.Location = new System.Drawing.Point(392, 129);
            nbPlacesLabel.Name = "nbPlacesLabel";
            nbPlacesLabel.Size = new System.Drawing.Size(56, 13);
            nbPlacesLabel.TabIndex = 7;
            nbPlacesLabel.Text = "nb Places:";
            // 
            // chambreIdLabel
            // 
            chambreIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chambreIdLabel.AutoSize = true;
            chambreIdLabel.Location = new System.Drawing.Point(383, 48);
            chambreIdLabel.Name = "chambreIdLabel";
            chambreIdLabel.Size = new System.Drawing.Size(65, 13);
            chambreIdLabel.TabIndex = 10;
            chambreIdLabel.Text = "chambre Id:";
            // 
            // gestionCiteDataSet
            // 
            this.gestionCiteDataSet.DataSetName = "GestionCiteDataSet";
            this.gestionCiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "Chambre";
            this.chambreBindingSource.DataSource = this.gestionCiteDataSet;
            this.chambreBindingSource.Filter = "";
            // 
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = this.chambreTableAdapter;
            this.tableAdapterManager.DateAnneeInscriptionTableAdapter = null;
            this.tableAdapterManager.EtudiantsQuitteTableAdapter = null;
            this.tableAdapterManager.EtudiantTableAdapter = null;
            this.tableAdapterManager.InscriptionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionCite.GestionCiteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // chambreGridControl
            // 
            this.chambreGridControl.DataSource = this.chambreBindingSource;
            this.chambreGridControl.Location = new System.Drawing.Point(6, 254);
            this.chambreGridControl.MainView = this.gridView1;
            this.chambreGridControl.Name = "chambreGridControl";
            this.chambreGridControl.Size = new System.Drawing.Size(911, 383);
            this.chambreGridControl.TabIndex = 0;
            this.chambreGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colchambreId,
            this.colnumeroChambre,
            this.colpavion,
            this.colnbPlaces});
            this.gridView1.GridControl = this.chambreGridControl;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colpavion, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colchambreId
            // 
            this.colchambreId.FieldName = "chambreId";
            this.colchambreId.Name = "colchambreId";
            this.colchambreId.Visible = true;
            this.colchambreId.VisibleIndex = 0;
            // 
            // colnumeroChambre
            // 
            this.colnumeroChambre.FieldName = "numeroChambre";
            this.colnumeroChambre.Name = "colnumeroChambre";
            this.colnumeroChambre.Visible = true;
            this.colnumeroChambre.VisibleIndex = 1;
            // 
            // colpavion
            // 
            this.colpavion.FieldName = "pavion";
            this.colpavion.Name = "colpavion";
            this.colpavion.Visible = true;
            this.colpavion.VisibleIndex = 2;
            // 
            // colnbPlaces
            // 
            this.colnbPlaces.FieldName = "nbPlaces";
            this.colnbPlaces.Name = "colnbPlaces";
            this.colnbPlaces.Visible = true;
            this.colnbPlaces.VisibleIndex = 2;
            // 
            // numeroChambreSpinEdit
            // 
            this.numeroChambreSpinEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numeroChambreSpinEdit.CausesValidation = false;
            this.numeroChambreSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.chambreBindingSource, "numeroChambre", true));
            this.numeroChambreSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numeroChambreSpinEdit.Enabled = false;
            this.numeroChambreSpinEdit.Location = new System.Drawing.Point(457, 74);
            this.numeroChambreSpinEdit.Name = "numeroChambreSpinEdit";
            this.numeroChambreSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numeroChambreSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.numeroChambreSpinEdit.TabIndex = 4;
            // 
            // pavionTextEdit
            // 
            this.pavionTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pavionTextEdit.CausesValidation = false;
            this.pavionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.chambreBindingSource, "pavion", true));
            this.pavionTextEdit.Enabled = false;
            this.pavionTextEdit.Location = new System.Drawing.Point(457, 100);
            this.pavionTextEdit.Name = "pavionTextEdit";
            this.pavionTextEdit.Size = new System.Drawing.Size(100, 20);
            this.pavionTextEdit.TabIndex = 6;
            // 
            // nbPlacesSpinEdit
            // 
            this.nbPlacesSpinEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nbPlacesSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.chambreBindingSource, "nbPlaces", true));
            this.nbPlacesSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nbPlacesSpinEdit.Enabled = false;
            this.nbPlacesSpinEdit.Location = new System.Drawing.Point(457, 126);
            this.nbPlacesSpinEdit.Name = "nbPlacesSpinEdit";
            this.nbPlacesSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nbPlacesSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.nbPlacesSpinEdit.TabIndex = 8;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Controls.Add(chambreIdLabel);
            this.groupControl1.Controls.Add(this.chambreIdLabel1);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.nbPlacesSpinEdit);
            this.groupControl1.Controls.Add(nbPlacesLabel);
            this.groupControl1.Controls.Add(numeroChambreLabel);
            this.groupControl1.Controls.Add(this.pavionTextEdit);
            this.groupControl1.Controls.Add(this.numeroChambreSpinEdit);
            this.groupControl1.Controls.Add(pavionLabel);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(914, 206);
            this.groupControl1.TabIndex = 9;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(878, 30);
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
            // chambreIdLabel1
            // 
            this.chambreIdLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chambreIdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chambreBindingSource, "chambreId", true));
            this.chambreIdLabel1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chambreIdLabel1.Location = new System.Drawing.Point(454, 48);
            this.chambreIdLabel1.Name = "chambreIdLabel1";
            this.chambreIdLabel1.Size = new System.Drawing.Size(100, 23);
            this.chambreIdLabel1.TabIndex = 11;
            this.chambreIdLabel1.Text = "label1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton2.Location = new System.Drawing.Point(457, 171);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "Annuler";
            this.simpleButton2.Visible = false;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton1.Location = new System.Drawing.Point(376, 171);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Valider";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton3.Location = new System.Drawing.Point(336, 5);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 10;
            this.simpleButton3.Text = "Ajouter";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton4.Location = new System.Drawing.Point(418, 5);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 11;
            this.simpleButton4.Text = "Modifier";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton5.Location = new System.Drawing.Point(500, 5);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 23);
            this.simpleButton5.TabIndex = 11;
            this.simpleButton5.Text = "Supprimer";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupControl2.Controls.Add(this.simpleButton5);
            this.groupControl2.Controls.Add(this.simpleButton3);
            this.groupControl2.Controls.Add(this.simpleButton4);
            this.groupControl2.Location = new System.Drawing.Point(6, 215);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(911, 33);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "groupControl2";
            // 
            // GestionPavEtChambres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.chambreGridControl);
            this.Name = "GestionPavEtChambres";
            this.Size = new System.Drawing.Size(920, 640);
            this.Load += new System.EventHandler(this.GestionPavEtChambres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionCiteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroChambreSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPlacesSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GestionCiteDataSet gestionCiteDataSet;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private GestionCiteDataSetTableAdapters.ChambreTableAdapter chambreTableAdapter;
        private GestionCiteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraDataLayout.DataLayoutControl chambreDataLayoutControl;
        private DevExpress.XtraGrid.GridControl chambreGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colchambreId;
        private DevExpress.XtraGrid.Columns.GridColumn colnumeroChambre;
        private DevExpress.XtraGrid.Columns.GridColumn colpavion;
        private DevExpress.XtraGrid.Columns.GridColumn colnbPlaces;
        private DevExpress.XtraEditors.SpinEdit numeroChambreSpinEdit;
        private DevExpress.XtraEditors.TextEdit pavionTextEdit;
        private DevExpress.XtraEditors.SpinEdit nbPlacesSpinEdit;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.Label chambreIdLabel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
