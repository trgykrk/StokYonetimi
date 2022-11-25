
namespace StokYonetimi.Formlar
{
    partial class frmAnaSayfa
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvMusteriHareketleri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.grdKritikSeviyedekiStoklar = new DevExpress.XtraGrid.GridControl();
            this.gvKritikSeviyedekiStoklar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gvMusteriAlisHareketleri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdMusteriAlisHareketleri = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gvMusteriHareketleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKritikSeviyedekiStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKritikSeviyedekiStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMusteriAlisHareketleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriAlisHareketleri)).BeginInit();
            this.SuspendLayout();
            // 
            // gvMusteriHareketleri
            // 
            this.gvMusteriHareketleri.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gvMusteriHareketleri.Appearance.Row.BackColor2 = System.Drawing.Color.Yellow;
            this.gvMusteriHareketleri.Appearance.Row.Options.UseBackColor = true;
            this.gvMusteriHareketleri.Name = "gvMusteriHareketleri";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grdMusteriAlisHareketleri);
            this.layoutControl1.Controls.Add(this.grdKritikSeviyedekiStoklar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(663, 461);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(663, 461);
            this.Root.TextVisible = false;
            // 
            // grdKritikSeviyedekiStoklar
            // 
            this.grdKritikSeviyedekiStoklar.Location = new System.Drawing.Point(12, 12);
            this.grdKritikSeviyedekiStoklar.MainView = this.gvKritikSeviyedekiStoklar;
            this.grdKritikSeviyedekiStoklar.Name = "grdKritikSeviyedekiStoklar";
            this.grdKritikSeviyedekiStoklar.Size = new System.Drawing.Size(317, 437);
            this.grdKritikSeviyedekiStoklar.TabIndex = 4;
            this.grdKritikSeviyedekiStoklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKritikSeviyedekiStoklar});
            // 
            // gvKritikSeviyedekiStoklar
            // 
            this.gvKritikSeviyedekiStoklar.Appearance.Row.BackColor = System.Drawing.Color.Red;
            this.gvKritikSeviyedekiStoklar.Appearance.Row.BackColor2 = System.Drawing.Color.Yellow;
            this.gvKritikSeviyedekiStoklar.Appearance.Row.Options.UseBackColor = true;
            this.gvKritikSeviyedekiStoklar.GridControl = this.grdKritikSeviyedekiStoklar;
            this.gvKritikSeviyedekiStoklar.Name = "gvKritikSeviyedekiStoklar";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdKritikSeviyedekiStoklar;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(321, 441);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grdMusteriAlisHareketleri;
            this.layoutControlItem2.Location = new System.Drawing.Point(321, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(322, 441);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // gvMusteriAlisHareketleri
            // 
            this.gvMusteriAlisHareketleri.Appearance.Row.BackColor = System.Drawing.Color.Teal;
            this.gvMusteriAlisHareketleri.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gvMusteriAlisHareketleri.Appearance.Row.Options.UseBackColor = true;
            this.gvMusteriAlisHareketleri.GridControl = this.grdMusteriAlisHareketleri;
            this.gvMusteriAlisHareketleri.Name = "gvMusteriAlisHareketleri";
            // 
            // grdMusteriAlisHareketleri
            // 
            this.grdMusteriAlisHareketleri.Location = new System.Drawing.Point(333, 12);
            this.grdMusteriAlisHareketleri.MainView = this.gvMusteriAlisHareketleri;
            this.grdMusteriAlisHareketleri.Name = "grdMusteriAlisHareketleri";
            this.grdMusteriAlisHareketleri.Size = new System.Drawing.Size(318, 437);
            this.grdMusteriAlisHareketleri.TabIndex = 5;
            this.grdMusteriAlisHareketleri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMusteriAlisHareketleri});
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 461);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmAnaSayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMusteriHareketleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKritikSeviyedekiStoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKritikSeviyedekiStoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMusteriAlisHareketleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriAlisHareketleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gvMusteriHareketleri;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl grdKritikSeviyedekiStoklar;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKritikSeviyedekiStoklar;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl grdMusteriAlisHareketleri;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMusteriAlisHareketleri;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}