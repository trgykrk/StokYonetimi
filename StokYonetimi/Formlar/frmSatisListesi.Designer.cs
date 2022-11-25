
namespace StokYonetimi.Formlar
{
    partial class frmSatisListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisListesi));
            this.grdSatisListesi = new DevExpress.XtraGrid.GridControl();
            this.gvSatisListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTCKimlikNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAciklamasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAlisFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokSatisFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ppMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnExceleGonder = new DevExpress.XtraBars.BarButtonItem();
            this.btnGorunumuSakla = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatisListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSatisListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSatisListesi
            // 
            this.grdSatisListesi.Location = new System.Drawing.Point(12, 12);
            this.grdSatisListesi.MainView = this.gvSatisListesi;
            this.grdSatisListesi.Name = "grdSatisListesi";
            this.grdSatisListesi.Size = new System.Drawing.Size(757, 459);
            this.grdSatisListesi.TabIndex = 4;
            this.grdSatisListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSatisListesi,
            this.gridView1,
            this.gridView2,
            this.gridView3});
            // 
            // gvSatisListesi
            // 
            this.gvSatisListesi.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gvSatisListesi.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvSatisListesi.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gvSatisListesi.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gvSatisListesi.Appearance.Row.BorderColor = System.Drawing.Color.Red;
            this.gvSatisListesi.Appearance.Row.Options.UseBackColor = true;
            this.gvSatisListesi.Appearance.Row.Options.UseBorderColor = true;
            this.gvSatisListesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCariKodu,
            this.colCariAdi,
            this.colCariSoyadi,
            this.colTCKimlikNo,
            this.colCariMail,
            this.colCariTelefon,
            this.colCariAdres,
            this.colTarih,
            this.colStokAdi,
            this.colStokKodu,
            this.colStokAciklamasi,
            this.colFiyat,
            this.colAdet,
            this.colToplamTutar,
            this.colStokImage,
            this.colCariRef,
            this.colStokRef,
            this.colStokBirim,
            this.colStokAlisFiyat,
            this.colStokSatisFiyat,
            this.colStokMiktari});
            this.gvSatisListesi.GridControl = this.grdSatisListesi;
            this.gvSatisListesi.Name = "gvSatisListesi";
            this.gvSatisListesi.OptionsView.ShowFooter = true;
            this.gvSatisListesi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gvSatisListesi_MouseUp);
            // 
            // colID
            // 
            this.colID.Caption = "Referans Numarası";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 47;
            // 
            // colCariKodu
            // 
            this.colCariKodu.Caption = "Cari Kodu";
            this.colCariKodu.FieldName = "Cari_Kodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.OptionsColumn.AllowEdit = false;
            this.colCariKodu.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cari_Kodu", "Kayıt Sayısı={0}")});
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 1;
            this.colCariKodu.Width = 47;
            // 
            // colCariAdi
            // 
            this.colCariAdi.Caption = "Adı";
            this.colCariAdi.FieldName = "Cari_Adi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.OptionsColumn.AllowEdit = false;
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 2;
            this.colCariAdi.Width = 47;
            // 
            // colCariSoyadi
            // 
            this.colCariSoyadi.Caption = "Soyadı";
            this.colCariSoyadi.FieldName = "Cari_Soyadi";
            this.colCariSoyadi.Name = "colCariSoyadi";
            this.colCariSoyadi.OptionsColumn.AllowEdit = false;
            this.colCariSoyadi.Visible = true;
            this.colCariSoyadi.VisibleIndex = 3;
            this.colCariSoyadi.Width = 47;
            // 
            // colTCKimlikNo
            // 
            this.colTCKimlikNo.Caption = "TC Kimlik Numarası";
            this.colTCKimlikNo.FieldName = "TC_KimlikNo";
            this.colTCKimlikNo.Name = "colTCKimlikNo";
            this.colTCKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTCKimlikNo.Visible = true;
            this.colTCKimlikNo.VisibleIndex = 4;
            this.colTCKimlikNo.Width = 47;
            // 
            // colCariMail
            // 
            this.colCariMail.Caption = "Mail Adresi";
            this.colCariMail.FieldName = "Cari_Mail";
            this.colCariMail.Name = "colCariMail";
            this.colCariMail.OptionsColumn.AllowEdit = false;
            this.colCariMail.Visible = true;
            this.colCariMail.VisibleIndex = 5;
            this.colCariMail.Width = 47;
            // 
            // colCariTelefon
            // 
            this.colCariTelefon.Caption = "Telefon";
            this.colCariTelefon.FieldName = "Cari_Telefon";
            this.colCariTelefon.Name = "colCariTelefon";
            this.colCariTelefon.OptionsColumn.AllowEdit = false;
            this.colCariTelefon.Visible = true;
            this.colCariTelefon.VisibleIndex = 6;
            this.colCariTelefon.Width = 47;
            // 
            // colCariAdres
            // 
            this.colCariAdres.Caption = "Adres Bilgisi";
            this.colCariAdres.FieldName = "Cari_Adres";
            this.colCariAdres.Name = "colCariAdres";
            this.colCariAdres.OptionsColumn.AllowEdit = false;
            this.colCariAdres.Visible = true;
            this.colCariAdres.VisibleIndex = 7;
            this.colCariAdres.Width = 47;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Fatura Tarihi";
            this.colTarih.DisplayFormat.FormatString = "d";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 15;
            this.colTarih.Width = 64;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adı";
            this.colStokAdi.FieldName = "Stok_Adi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 9;
            this.colStokAdi.Width = 49;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "Stok_Kodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 8;
            this.colStokKodu.Width = 46;
            // 
            // colStokAciklamasi
            // 
            this.colStokAciklamasi.Caption = "Stok Açıklaması";
            this.colStokAciklamasi.FieldName = "Stok_Aciklamasi";
            this.colStokAciklamasi.Name = "colStokAciklamasi";
            this.colStokAciklamasi.OptionsColumn.AllowEdit = false;
            this.colStokAciklamasi.Visible = true;
            this.colStokAciklamasi.VisibleIndex = 10;
            this.colStokAciklamasi.Width = 39;
            // 
            // colFiyat
            // 
            this.colFiyat.Caption = "Birim Fiyat";
            this.colFiyat.FieldName = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.OptionsColumn.AllowEdit = false;
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 11;
            this.colFiyat.Width = 62;
            // 
            // colAdet
            // 
            this.colAdet.Caption = "Satış Miktarı";
            this.colAdet.FieldName = "Adet";
            this.colAdet.Name = "colAdet";
            this.colAdet.OptionsColumn.AllowEdit = false;
            this.colAdet.Visible = true;
            this.colAdet.VisibleIndex = 12;
            this.colAdet.Width = 39;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Caption = "Toplam Tutar";
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Date;
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ToplamTutar", "Gelir={0:C2}")});
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 14;
            this.colToplamTutar.Width = 57;
            // 
            // colStokImage
            // 
            this.colStokImage.Caption = "Resim Dosyası";
            this.colStokImage.FieldName = "Stok_Image";
            this.colStokImage.Name = "colStokImage";
            this.colStokImage.OptionsColumn.AllowEdit = false;
            // 
            // colCariRef
            // 
            this.colCariRef.Caption = "Cari Referans No";
            this.colCariRef.FieldName = "Cari_Ref";
            this.colCariRef.Name = "colCariRef";
            this.colCariRef.OptionsColumn.AllowEdit = false;
            // 
            // colStokRef
            // 
            this.colStokRef.Caption = "Stok Referans No";
            this.colStokRef.FieldName = "Stok_Ref";
            this.colStokRef.Name = "colStokRef";
            this.colStokRef.OptionsColumn.AllowEdit = false;
            // 
            // colStokBirim
            // 
            this.colStokBirim.Caption = "Birimi";
            this.colStokBirim.FieldName = "Stok_Birim";
            this.colStokBirim.Name = "colStokBirim";
            this.colStokBirim.OptionsColumn.AllowEdit = false;
            this.colStokBirim.Visible = true;
            this.colStokBirim.VisibleIndex = 13;
            // 
            // colStokAlisFiyat
            // 
            this.colStokAlisFiyat.Caption = "Stok Alış Fiyatı";
            this.colStokAlisFiyat.FieldName = "Stok_AlisFiyat";
            this.colStokAlisFiyat.Name = "colStokAlisFiyat";
            this.colStokAlisFiyat.OptionsColumn.AllowEdit = false;
            // 
            // colStokSatisFiyat
            // 
            this.colStokSatisFiyat.Caption = "Satış Fiyatı";
            this.colStokSatisFiyat.FieldName = "Stok_SatisFiyat";
            this.colStokSatisFiyat.Name = "colStokSatisFiyat";
            this.colStokSatisFiyat.OptionsColumn.AllowEdit = false;
            // 
            // colStokMiktari
            // 
            this.colStokMiktari.Caption = "Stok Miktarı";
            this.colStokMiktari.FieldName = "Stok_Miktari";
            this.colStokMiktari.Name = "colStokMiktari";
            this.colStokMiktari.OptionsColumn.AllowEdit = false;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdSatisListesi;
            this.gridView1.Name = "gridView1";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdSatisListesi;
            this.gridView2.Name = "gridView2";
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.grdSatisListesi;
            this.gridView3.Name = "gridView3";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(781, 483);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grdSatisListesi;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(761, 463);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grdSatisListesi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(781, 483);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ppMenu
            // 
            this.ppMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExceleGonder),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGorunumuSakla)});
            this.ppMenu.Manager = this.barManager1;
            this.ppMenu.Name = "ppMenu";
            // 
            // btnExceleGonder
            // 
            this.btnExceleGonder.Caption = "Excele Gönder";
            this.btnExceleGonder.Id = 0;
            this.btnExceleGonder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExceleGonder.ImageOptions.SvgImage")));
            this.btnExceleGonder.Name = "btnExceleGonder";
            this.btnExceleGonder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExceleGonder_ItemClick);
            // 
            // btnGorunumuSakla
            // 
            this.btnGorunumuSakla.Caption = "Görünümü Sakla";
            this.btnGorunumuSakla.Id = 1;
            this.btnGorunumuSakla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGorunumuSakla.ImageOptions.Image")));
            this.btnGorunumuSakla.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGorunumuSakla.ImageOptions.LargeImage")));
            this.btnGorunumuSakla.Name = "btnGorunumuSakla";
            this.btnGorunumuSakla.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGorunumuSakla_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnExceleGonder,
            this.btnGorunumuSakla});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(781, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 483);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(781, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 483);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(781, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 483);
            // 
            // frmSatisListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 483);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSatisListesi";
            this.Text = "Satış İşlemleri";
            this.Load += new System.EventHandler(this.frmSatisListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSatisListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSatisListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ppMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdSatisListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSatisListesi;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;     
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colCariSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colCariMail;
        private DevExpress.XtraGrid.Columns.GridColumn colCariTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colAdet;
        private DevExpress.XtraGrid.Columns.GridColumn colCariRef;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colStokRef;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAciklamasi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAlisFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colStokBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colStokImage;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokSatisFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colStokMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colTCKimlikNo;
        private DevExpress.XtraBars.PopupMenu ppMenu;
        private DevExpress.XtraBars.BarButtonItem btnExceleGonder;
        private DevExpress.XtraBars.BarButtonItem btnGorunumuSakla;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}