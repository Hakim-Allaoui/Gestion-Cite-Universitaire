namespace GestionCite
{
    partial class GestionDateAnnee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDateAnnee));
            this.gestionCiteDataSet = new GestionCite.GestionCiteDataSet();
            this.dateAnneeInscriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateAnneeInscriptionTableAdapter = new GestionCite.GestionCiteDataSetTableAdapters.DateAnneeInscriptionTableAdapter();
            this.tableAdapterManager = new GestionCite.GestionCiteDataSetTableAdapters.TableAdapterManager();
            this.dateAnneeInscriptionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dateAnneeInscriptionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dateAnneeInscriptionGridControl = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCiteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAnneeInscriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAnneeInscriptionBindingNavigator)).BeginInit();
            this.dateAnneeInscriptionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateAnneeInscriptionGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gestionCiteDataSet
            // 
            this.gestionCiteDataSet.DataSetName = "GestionCiteDataSet";
            this.gestionCiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateAnneeInscriptionBindingSource
            // 
            this.dateAnneeInscriptionBindingSource.DataMember = "DateAnneeInscription";
            this.dateAnneeInscriptionBindingSource.DataSource = this.gestionCiteDataSet;
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
            // dateAnneeInscriptionBindingNavigator
            // 
            this.dateAnneeInscriptionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dateAnneeInscriptionBindingNavigator.BindingSource = this.dateAnneeInscriptionBindingSource;
            this.dateAnneeInscriptionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dateAnneeInscriptionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dateAnneeInscriptionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dateAnneeInscriptionBindingNavigatorSaveItem});
            this.dateAnneeInscriptionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dateAnneeInscriptionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dateAnneeInscriptionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dateAnneeInscriptionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dateAnneeInscriptionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dateAnneeInscriptionBindingNavigator.Name = "dateAnneeInscriptionBindingNavigator";
            this.dateAnneeInscriptionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dateAnneeInscriptionBindingNavigator.Size = new System.Drawing.Size(920, 25);
            this.dateAnneeInscriptionBindingNavigator.TabIndex = 0;
            this.dateAnneeInscriptionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dateAnneeInscriptionBindingNavigatorSaveItem
            // 
            this.dateAnneeInscriptionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dateAnneeInscriptionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dateAnneeInscriptionBindingNavigatorSaveItem.Image")));
            this.dateAnneeInscriptionBindingNavigatorSaveItem.Name = "dateAnneeInscriptionBindingNavigatorSaveItem";
            this.dateAnneeInscriptionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dateAnneeInscriptionBindingNavigatorSaveItem.Text = "Save Data";
            this.dateAnneeInscriptionBindingNavigatorSaveItem.Click += new System.EventHandler(this.dateAnneeInscriptionBindingNavigatorSaveItem_Click);
            // 
            // dateAnneeInscriptionGridControl
            // 
            this.dateAnneeInscriptionGridControl.DataSource = this.dateAnneeInscriptionBindingSource;
            this.dateAnneeInscriptionGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateAnneeInscriptionGridControl.Location = new System.Drawing.Point(0, 25);
            this.dateAnneeInscriptionGridControl.MainView = this.cardView1;
            this.dateAnneeInscriptionGridControl.Name = "dateAnneeInscriptionGridControl";
            this.dateAnneeInscriptionGridControl.Size = new System.Drawing.Size(920, 615);
            this.dateAnneeInscriptionGridControl.TabIndex = 1;
            this.dateAnneeInscriptionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.GridControl = this.dateAnneeInscriptionGridControl;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // GestionDateAnnee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateAnneeInscriptionGridControl);
            this.Controls.Add(this.dateAnneeInscriptionBindingNavigator);
            this.Name = "GestionDateAnnee";
            this.Size = new System.Drawing.Size(920, 640);
            this.Load += new System.EventHandler(this.GestionDateAnnee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionCiteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAnneeInscriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAnneeInscriptionBindingNavigator)).EndInit();
            this.dateAnneeInscriptionBindingNavigator.ResumeLayout(false);
            this.dateAnneeInscriptionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateAnneeInscriptionGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GestionCiteDataSet gestionCiteDataSet;
        private System.Windows.Forms.BindingSource dateAnneeInscriptionBindingSource;
        private GestionCiteDataSetTableAdapters.DateAnneeInscriptionTableAdapter dateAnneeInscriptionTableAdapter;
        private GestionCiteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dateAnneeInscriptionBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dateAnneeInscriptionBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl dateAnneeInscriptionGridControl;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
    }
}
