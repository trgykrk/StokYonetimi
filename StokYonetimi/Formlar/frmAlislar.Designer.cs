
namespace StokYonetimi.Formlar
{
    partial class frmAlislar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlislar));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grdAlislar = new DevExpress.XtraGrid.GridControl();
            this.gvAlislar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAciklamasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAlisFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStok_Image = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokSatisFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cardView4 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cardView3 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.cardView2 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ppMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnExceleGonder = new DevExpress.XtraBars.BarButtonItem();
            this.btnGorunumuSakla = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grdAlislar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(639, 444);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = " ";
            // 
            // grdAlislar
            // 
            this.grdAlislar.Location = new System.Drawing.Point(12, 12);
            this.grdAlislar.MainView = this.gvAlislar;
            this.grdAlislar.Name = "grdAlislar";
            this.grdAlislar.Size = new System.Drawing.Size(615, 420);
            this.grdAlislar.TabIndex = 4;
            this.grdAlislar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAlislar,
            this.cardView4,
            this.gridView2,
            this.cardView3,
            this.cardView2});
            // 
            // gvAlislar
            // 
            this.gvAlislar.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gvAlislar.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gvAlislar.Appearance.Row.Options.UseBackColor = true;
            this.gvAlislar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTarih,
            this.colAdet,
            this.colFiyat,
            this.colToplamTutar,
            this.colStokRef,
            this.colStokAdi,
            this.colStokAciklamasi,
            this.colStokAlisFiyat,
            this.colStokBirim,
            this.colStokKodu,
            this.colStok_Image,
            this.colStokMiktari,
            this.colStokSatisFiyat});
            this.gvAlislar.GridControl = this.grdAlislar;
            this.gvAlislar.Name = "gvAlislar";
            this.gvAlislar.OptionsView.ShowFooter = true;
            this.gvAlislar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gvAlislar_MouseUp);
            // 
            // colID
            // 
            this.colID.Caption = "Fatura Referans No";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
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
            this.colTarih.VisibleIndex = 1;
            // 
            // colAdet
            // 
            this.colAdet.Caption = "Alınan Miktar";
            this.colAdet.FieldName = "Adet";
            this.colAdet.Name = "colAdet";
            this.colAdet.OptionsColumn.AllowEdit = false;
            this.colAdet.Visible = true;
            this.colAdet.VisibleIndex = 2;
            // 
            // colFiyat
            // 
            this.colFiyat.Caption = "Alış Birim Fiyatı";
            this.colFiyat.FieldName = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.OptionsColumn.AllowEdit = false;
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 3;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Caption = "Toplam Tutar";
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ToplamTutar", "Gider={0:C2}")});
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 4;
            // 
            // colStokRef
            // 
            this.colStokRef.Caption = "Stok Referans No";
            this.colStokRef.FieldName = "Stok_Ref";
            this.colStokRef.Name = "colStokRef";
            this.colStokRef.OptionsColumn.AllowEdit = false;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Ürün Adı";
            this.colStokAdi.FieldName = "Stok_Adi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 5;
            // 
            // colStokAciklamasi
            // 
            this.colStokAciklamasi.Caption = "Ürün Açıklaması";
            this.colStokAciklamasi.FieldName = "Stok_Aciklamasi";
            this.colStokAciklamasi.Name = "colStokAciklamasi";
            this.colStokAciklamasi.OptionsColumn.AllowEdit = false;
            this.colStokAciklamasi.Visible = true;
            this.colStokAciklamasi.VisibleIndex = 6;
            // 
            // colStokAlisFiyat
            // 
            this.colStokAlisFiyat.Caption = "Stok Alış Fiyatı";
            this.colStokAlisFiyat.FieldName = "Stok_AlisFiyat";
            this.colStokAlisFiyat.Name = "colStokAlisFiyat";
            this.colStokAlisFiyat.OptionsColumn.AllowEdit = false;
            // 
            // colStokBirim
            // 
            this.colStokBirim.Caption = "Stok Birimi";
            this.colStokBirim.FieldName = "Stok_Birim";
            this.colStokBirim.Name = "colStokBirim";
            this.colStokBirim.OptionsColumn.AllowEdit = false;
            this.colStokBirim.Visible = true;
            this.colStokBirim.VisibleIndex = 7;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Ürün Kodu";
            this.colStokKodu.FieldName = "Stok_Kodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 8;
            // 
            // colStok_Image
            // 
            this.colStok_Image.Caption = "Resim Dosyası";
            this.colStok_Image.FieldName = "Stok_Image";
            this.colStok_Image.Name = "colStok_Image";
            this.colStok_Image.OptionsColumn.AllowEdit = false;
            this.colStok_Image.Visible = true;
            this.colStok_Image.VisibleIndex = 9;
            // 
            // colStokMiktari
            // 
            this.colStokMiktari.Caption = "Ürün Miktarı";
            this.colStokMiktari.FieldName = "Stok_Miktari";
            this.colStokMiktari.Name = "colStokMiktari";
            this.colStokMiktari.OptionsColumn.AllowEdit = false;
            // 
            // colStokSatisFiyat
            // 
            this.colStokSatisFiyat.Caption = "Ürünün Satış Fiyatı";
            this.colStokSatisFiyat.FieldName = "Stok_SatisFiyat";
            this.colStokSatisFiyat.Name = "colStokSatisFiyat";
            this.colStokSatisFiyat.OptionsColumn.AllowEdit = false;
            // 
            // cardView4
            // 
            this.cardView4.GridControl = this.grdAlislar;
            this.cardView4.Name = "cardView4";
            // 
            // gridView2
            // 
            this.gridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.Red;
            this.gridView2.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView2.GridControl = this.grdAlislar;
            this.gridView2.Name = "gridView2";
            // 
            // cardView3
            // 
            this.cardView3.GridControl = this.grdAlislar;
            this.cardView3.Name = "cardView3";
            // 
            // cardView2
            // 
            this.cardView2.GridControl = this.grdAlislar;
            this.cardView2.Name = "cardView2";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(639, 444);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdAlislar;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(619, 424);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
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
            this.barDockControlTop.Size = new System.Drawing.Size(639, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 444);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(639, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 444);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(639, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 444);
            // 
            // frmAlislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 444);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmAlislar";
            this.Text = "Alışlar";
            this.Load += new System.EventHandler(this.frmAlislar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAlislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grdAlislar;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAlislar;
        private DevExpress.XtraGrid.Views.Card.CardView cardView4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Card.CardView cardView3;
        private DevExpress.XtraGrid.Views.Card.CardView cardView2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colAdet;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colStokRef;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAciklamasi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAlisFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colStokBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStok_Image;
        private DevExpress.XtraGrid.Columns.GridColumn colStokMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colStokSatisFiyat;
        private DevExpress.XtraBars.PopupMenu ppMenu;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnExceleGonder;
        private DevExpress.XtraBars.BarButtonItem btnGorunumuSakla;
    }
}