namespace GestionCite
{
    partial class ListInscrition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListInscrition));
            this.gestionCiteDataSet = new GestionCite.GestionCiteDataSet();
            this.inscriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscriptionTableAdapter = new GestionCite.GestionCiteDataSetTableAdapters.InscriptionTableAdapter();
            this.tableAdapterManager = new GestionCite.GestionCiteDataSetTableAdapters.TableAdapterManager();
            this.inscriptionGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnumInscription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldateInscription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldateAnneeInscription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumCotisation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumDossier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchambre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colniveau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCiteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gestionCiteDataSet
            // 
            this.gestionCiteDataSet.DataSetName = "GestionCiteDataSet";
            this.gestionCiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inscriptionBindingSource
            // 
            this.inscriptionBindingSource.DataMember = "Inscription";
            this.inscriptionBindingSource.DataSource = this.gestionCiteDataSet;
            // 
            // inscriptionTableAdapter
            // 
            this.inscriptionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.DateAnneeInscriptionTableAdapter = null;
            this.tableAdapterManager.EtudiantsQuitteTableAdapter = null;
            this.tableAdapterManager.EtudiantTableAdapter = null;
            this.tableAdapterManager.InscriptionTableAdapter = this.inscriptionTableAdapter;
            this.tableAdapterManager.UpdateOrder = GestionCite.GestionCiteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // inscriptionGridControl
            // 
            this.inscriptionGridControl.DataSource = this.inscriptionBindingSource;
            this.inscriptionGridControl.Location = new System.Drawing.Point(3, 137);
            this.inscriptionGridControl.MainView = this.gridView1;
            this.inscriptionGridControl.Name = "inscriptionGridControl";
            this.inscriptionGridControl.Size = new System.Drawing.Size(914, 500);
            this.inscriptionGridControl.TabIndex = 1;
            this.inscriptionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnumInscription,
            this.coldateInscription,
            this.coldateAnneeInscription,
            this.colnumCotisation,
            this.colnumDossier,
            this.colchambre,
            this.colniveau});
            this.gridView1.GridControl = this.inscriptionGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler(this.gridView1_BeforeLeaveRow);
            // 
            // colnumInscription
            // 
            this.colnumInscription.FieldName = "numInscription";
            this.colnumInscription.Name = "colnumInscription";
            this.colnumInscription.Visible = true;
            this.colnumInscription.VisibleIndex = 0;
            // 
            // coldateInscription
            // 
            this.coldateInscription.FieldName = "dateInscription";
            this.coldateInscription.Name = "coldateInscription";
            this.coldateInscription.Visible = true;
            this.coldateInscription.VisibleIndex = 1;
            // 
            // coldateAnneeInscription
            // 
            this.coldateAnneeInscription.FieldName = "dateAnneeInscription";
            this.coldateAnneeInscription.Name = "coldateAnneeInscription";
            this.coldateAnneeInscription.Visible = true;
            this.coldateAnneeInscription.VisibleIndex = 2;
            // 
            // colnumCotisation
            // 
            this.colnumCotisation.FieldName = "numCotisation";
            this.colnumCotisation.Name = "colnumCotisation";
            this.colnumCotisation.Visible = true;
            this.colnumCotisation.VisibleIndex = 3;
            // 
            // colnumDossier
            // 
            this.colnumDossier.FieldName = "numDossier";
            this.colnumDossier.Name = "colnumDossier";
            this.colnumDossier.Visible = true;
            this.colnumDossier.VisibleIndex = 4;
            // 
            // colchambre
            // 
            this.colchambre.FieldName = "chambre";
            this.colchambre.Name = "colchambre";
            this.colchambre.Visible = true;
            this.colchambre.VisibleIndex = 5;
            // 
            // colniveau
            // 
            this.colniveau.FieldName = "niveau";
            this.colniveau.Name = "colniveau";
            this.colniveau.Visible = true;
            this.colniveau.VisibleIndex = 6;
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textEdit1.Location = new System.Drawing.Point(286, 22);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.AutoHeight = false;
            this.textEdit1.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("textEdit1.Properties.ContextImageOptions.SvgImage")));
            this.textEdit1.Size = new System.Drawing.Size(363, 36);
            this.textEdit1.TabIndex = 2;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(886, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(31, 31);
            this.pictureEdit1.TabIndex = 28;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.dataNavigator1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataNavigator1.Buttons.Append.Enabled = false;
            this.dataNavigator1.Buttons.Append.Visible = false;
            this.dataNavigator1.DataSource = this.inscriptionBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(286, 64);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.ShowToolTips = true;
            this.dataNavigator1.Size = new System.Drawing.Size(363, 24);
            this.dataNavigator1.TabIndex = 29;
            this.dataNavigator1.Text = "dataNavigator1";
            this.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.dataNavigator1.TextStringFormat = "{0} of {1}";
            this.dataNavigator1.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.dataNavigator1_ButtonClick);
            // 
            // ListInscrition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataNavigator1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.inscriptionGridControl);
            this.Name = "ListInscrition";
            this.Size = new System.Drawing.Size(920, 640);
            this.Load += new System.EventHandler(this.ListInscrition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionCiteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GestionCiteDataSet gestionCiteDataSet;
        private System.Windows.Forms.BindingSource inscriptionBindingSource;
        private GestionCiteDataSetTableAdapters.InscriptionTableAdapter inscriptionTableAdapter;
        private GestionCiteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl inscriptionGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraGrid.Columns.GridColumn colnumInscription;
        private DevExpress.XtraGrid.Columns.GridColumn coldateInscription;
        private DevExpress.XtraGrid.Columns.GridColumn coldateAnneeInscription;
        private DevExpress.XtraGrid.Columns.GridColumn colnumCotisation;
        private DevExpress.XtraGrid.Columns.GridColumn colnumDossier;
        private DevExpress.XtraGrid.Columns.GridColumn colchambre;
        private DevExpress.XtraGrid.Columns.GridColumn colniveau;
    }
}
