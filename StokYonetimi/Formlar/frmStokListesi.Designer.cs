
namespace StokYonetimi.Formlar
{
    partial class frmStokListesi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokListesi));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grdStokListesi = new DevExpress.XtraGrid.GridControl();
            this.gvStokListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAlisFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokSatisFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAciklamasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRatingControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemRatingControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ppmStokListesi = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.btnExceleGonder = new DevExpress.XtraBars.BarButtonItem();
            this.btnPdfGonder = new DevExpress.XtraBars.BarButtonItem();
            this.btnGorunumuSakla = new DevExpress.XtraBars.BarButtonItem();
            this.bmStokListesi = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStokListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStokListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRatingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppmStokListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmStokListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grdStokListesi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1007, 446);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grdStokListesi
            // 
            this.grdStokListesi.Location = new System.Drawing.Point(24, 42);
            this.grdStokListesi.MainView = this.gvStokListesi;
            this.grdStokListesi.Name = "grdStokListesi";
            this.grdStokListesi.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRatingControl1});
            this.grdStokListesi.Size = new System.Drawing.Size(959, 380);
            this.grdStokListesi.TabIndex = 4;
            this.grdStokListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStokListesi});
            // 
            // gvStokListesi
            // 
            this.gvStokListesi.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gvStokListesi.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gvStokListesi.Appearance.Row.Options.UseBackColor = true;
            this.gvStokListesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colStokKodu,
            this.colStokAdi,
            this.colStokBirim,
            this.colStokAlisFiyat,
            this.colStokSatisFiyat,
            this.colStokMiktari,
            this.colStokAciklamasi,
            this.colStokImage});
            this.gvStokListesi.GridControl = this.grdStokListesi;
            this.gvStokListesi.Name = "gvStokListesi";
            this.gvStokListesi.OptionsView.ShowAutoFilterRow = true;
            this.gvStokListesi.OptionsView.ShowGroupPanel = false;
            this.gvStokListesi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gvStokListesi_MouseUp);
            // 
            // colID
            // 
            this.colID.Caption = "Stok Referans No";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", "Kayıt Sayısı={0}")});
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Ürün Kodu";
            this.colStokKodu.FieldName = "Stok_Kodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, DevExpress.Data.SummaryMode.Mixed, "Stok_Kodu", "Kayıt Sayısı={0}")});
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 0;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Ürün Adı";
            this.colStokAdi.FieldName = "Stok_Adi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 1;
            // 
            // colStokBirim
            // 
            this.colStokBirim.Caption = "Birim";
            this.colStokBirim.FieldName = "Stok_Birim";
            this.colStokBirim.Name = "colStokBirim";
            this.colStokBirim.OptionsColumn.AllowEdit = false;
            this.colStokBirim.Visible = true;
            this.colStokBirim.VisibleIndex = 2;
            // 
            // colStokAlisFiyat
            // 
            this.colStokAlisFiyat.Caption = "Alış Fiyatı";
            this.colStokAlisFiyat.FieldName = "Stok_AlisFiyat";
            this.colStokAlisFiyat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colStokAlisFiyat.ImageOptions.Image")));
            this.colStokAlisFiyat.ImageOptions.ImageUri.Uri = "icon%20builder/actions_arrow4down";
            this.colStokAlisFiyat.Name = "colStokAlisFiyat";
            this.colStokAlisFiyat.OptionsColumn.AllowEdit = false;
            this.colStokAlisFiyat.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Stok_AlisFiyat", "Gider={0:C2}")});
            this.colStokAlisFiyat.Visible = true;
            this.colStokAlisFiyat.VisibleIndex = 3;
            // 
            // colStokSatisFiyat
            // 
            this.colStokSatisFiyat.Caption = "Satış Fiyatı";
            this.colStokSatisFiyat.FieldName = "Stok_SatisFiyat";
            this.colStokSatisFiyat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colStokSatisFiyat.ImageOptions.Image")));
            this.colStokSatisFiyat.Name = "colStokSatisFiyat";
            this.colStokSatisFiyat.OptionsColumn.AllowEdit = false;
            this.colStokSatisFiyat.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Stok_SatisFiyat", "Gelir={0:C2}")});
            this.colStokSatisFiyat.Visible = true;
            this.colStokSatisFiyat.VisibleIndex = 4;
            // 
            // colStokMiktari
            // 
            this.colStokMiktari.Caption = "Ürün Miktarı";
            this.colStokMiktari.FieldName = "Stok_Miktari";
            this.colStokMiktari.Name = "colStokMiktari";
            this.colStokMiktari.OptionsColumn.AllowEdit = false;
            this.colStokMiktari.Visible = true;
            this.colStokMiktari.VisibleIndex = 5;
            // 
            // colStokAciklamasi
            // 
            this.colStokAciklamasi.Caption = "Stok Açıklaması";
            this.colStokAciklamasi.FieldName = "Stok_Aciklamasi";
            this.colStokAciklamasi.Name = "colStokAciklamasi";
            this.colStokAciklamasi.OptionsColumn.AllowEdit = false;
            this.colStokAciklamasi.Visible = true;
            this.colStokAciklamasi.VisibleIndex = 6;
            // 
            // colStokImage
            // 
            this.colStokImage.Caption = "Resim Dosyası";
            this.colStokImage.FieldName = "Stok_Image";
            this.colStokImage.Name = "colStokImage";
            this.colStokImage.OptionsColumn.AllowEdit = false;
            this.colStokImage.Visible = true;
            this.colStokImage.VisibleIndex = 7;
            // 
            // repositoryItemRatingControl1
            // 
            this.repositoryItemRatingControl1.AutoHeight = false;
            this.repositoryItemRatingControl1.Name = "repositoryItemRatingControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1007, 446);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup1.CaptionImageOptions.Image")));
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(987, 426);
            this.layoutControlGroup1.Text = "Ürün Listesi";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdStokListesi;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(963, 384);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ppmStokListesi
            // 
            this.ppmStokListesi.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSil),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGuncelle),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExceleGonder),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPdfGonder),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGorunumuSakla)});
            this.ppmStokListesi.Manager = this.bmStokListesi;
            this.ppmStokListesi.Name = "ppmStokListesi";
            // 
            // btnSil
            // 
            this.btnSil.Caption = "Sil";
            this.btnSil.Id = 0;
            this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSil.ImageOptions.SvgImage")));
            this.btnSil.Name = "btnSil";
            this.btnSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSil_ItemClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Caption = "Güncelle";
            this.btnGuncelle.Id = 1;
            this.btnGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuncelle.ImageOptions.SvgImage")));
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuncelle_ItemClick);
            // 
            // btnExceleGonder
            // 
            this.btnExceleGonder.Caption = "Excele Gönder";
            this.btnExceleGonder.Id = 2;
            this.btnExceleGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExceleGonder.ImageOptions.Image")));
            this.btnExceleGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExceleGonder.ImageOptions.LargeImage")));
            this.btnExceleGonder.Name = "btnExceleGonder";
            this.btnExceleGonder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExceleGonder_ItemClick);
            // 
            // btnPdfGonder
            // 
            this.btnPdfGonder.Caption = "Pdf Gönder";
            this.btnPdfGonder.Id = 3;
            this.btnPdfGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPdfGonder.ImageOptions.Image")));
            this.btnPdfGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPdfGonder.ImageOptions.LargeImage")));
            this.btnPdfGonder.Name = "btnPdfGonder";
            // 
            // btnGorunumuSakla
            // 
            this.btnGorunumuSakla.Caption = "Görünümü Sakla";
            this.btnGorunumuSakla.Id = 4;
            this.btnGorunumuSakla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGorunumuSakla.ImageOptions.Image")));
            this.btnGorunumuSakla.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGorunumuSakla.ImageOptions.LargeImage")));
            this.btnGorunumuSakla.Name = "btnGorunumuSakla";
            this.btnGorunumuSakla.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGorunumuSakla_ItemClick);
            // 
            // bmStokListesi
            // 
            this.bmStokListesi.DockControls.Add(this.barDockControlTop);
            this.bmStokListesi.DockControls.Add(this.barDockControlBottom);
            this.bmStokListesi.DockControls.Add(this.barDockControlLeft);
            this.bmStokListesi.DockControls.Add(this.barDockControlRight);
            this.bmStokListesi.Form = this;
            this.bmStokListesi.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSil,
            this.btnGuncelle,
            this.btnExceleGonder,
            this.btnPdfGonder,
            this.btnGorunumuSakla});
            this.bmStokListesi.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bmStokListesi;
            this.barDockControlTop.Size = new System.Drawing.Size(1007, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 446);
            this.barDockControlBottom.Manager = this.bmStokListesi;
            this.barDockControlBottom.Size = new System.Drawing.Size(1007, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.bmStokListesi;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 446);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1007, 0);
            this.barDockControlRight.Manager = this.bmStokListesi;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 446);
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "c9c8b218-915d-4651-9732-a59020a87952";
            // 
            // frmStokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 446);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmStokListesi.IconOptions.Image")));
            this.Name = "frmStokListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Listesi";
            this.Load += new System.EventHandler(this.frmStokListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStokListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStokListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRatingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppmStokListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmStokListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grdStokListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStokListesi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAlisFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colStokSatisFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colStokMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAciklamasi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemRatingControl repositoryItemRatingControl1;
        private DevExpress.XtraBars.PopupMenu ppmStokListesi;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private DevExpress.XtraBars.BarButtonItem btnGuncelle;
        private DevExpress.XtraBars.BarManager bmStokListesi;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraBars.BarButtonItem btnExceleGonder;
        private DevExpress.XtraBars.BarButtonItem btnPdfGonder;
        private DevExpress.XtraBars.BarButtonItem btnGorunumuSakla;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    }
}