
namespace StokYonetimi.Formlar
{
    partial class frmCariKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariKayit));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtCariKodu = new DevExpress.XtraEditors.TextEdit();
            this.txtTCKimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefonNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.txtMailAdresi = new DevExpress.XtraEditors.TextEdit();
            this.txtAdresBilgisi = new DevExpress.XtraEditors.TextEdit();
            this.txtAdi = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgGenelBilgiler = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgIletisimBilgileri = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgAdresBilgileri = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMailAdresi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdresBilgisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgGenelBilgiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgIletisimBilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAdresBilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtCariKodu);
            this.layoutControl1.Controls.Add(this.txtTCKimlikNo);
            this.layoutControl1.Controls.Add(this.txtTelefonNumarasi);
            this.layoutControl1.Controls.Add(this.btnVazgec);
            this.layoutControl1.Controls.Add(this.btnKaydet);
            this.layoutControl1.Controls.Add(this.txtSoyadi);
            this.layoutControl1.Controls.Add(this.txtMailAdresi);
            this.layoutControl1.Controls.Add(this.txtAdresBilgisi);
            this.layoutControl1.Controls.Add(this.txtAdi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(380, 368);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Location = new System.Drawing.Point(124, 39);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Size = new System.Drawing.Size(232, 22);
            this.txtCariKodu.StyleController = this.layoutControl1;
            this.txtCariKodu.TabIndex = 76;
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.Location = new System.Drawing.Point(124, 65);
            this.txtTCKimlikNo.Mask = "00000000000";
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Size = new System.Drawing.Size(232, 20);
            this.txtTCKimlikNo.TabIndex = 74;
            this.txtTCKimlikNo.ValidatingType = typeof(int);
            // 
            // txtTelefonNumarasi
            // 
            this.txtTelefonNumarasi.Location = new System.Drawing.Point(124, 180);
            this.txtTelefonNumarasi.Mask = "(999) 000-0000";
            this.txtTelefonNumarasi.Name = "txtTelefonNumarasi";
            this.txtTelefonNumarasi.Size = new System.Drawing.Size(232, 21);
            this.txtTelefonNumarasi.TabIndex = 73;
            // 
            // btnVazgec
            // 
            this.btnVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.ImageOptions.Image")));
            this.btnVazgec.Location = new System.Drawing.Point(12, 334);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(356, 22);
            this.btnVazgec.StyleController = this.layoutControl1;
            this.btnVazgec.TabIndex = 72;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click_1);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(12, 308);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(356, 22);
            this.btnKaydet.StyleController = this.layoutControl1;
            this.btnKaydet.TabIndex = 71;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(124, 115);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(232, 22);
            this.txtSoyadi.StyleController = this.layoutControl1;
            this.txtSoyadi.TabIndex = 70;
            // 
            // txtMailAdresi
            // 
            this.txtMailAdresi.Location = new System.Drawing.Point(124, 205);
            this.txtMailAdresi.Name = "txtMailAdresi";
            this.txtMailAdresi.Size = new System.Drawing.Size(232, 22);
            this.txtMailAdresi.StyleController = this.layoutControl1;
            this.txtMailAdresi.TabIndex = 69;
            // 
            // txtAdresBilgisi
            // 
            this.txtAdresBilgisi.Location = new System.Drawing.Point(124, 270);
            this.txtAdresBilgisi.Name = "txtAdresBilgisi";
            this.txtAdresBilgisi.Size = new System.Drawing.Size(232, 22);
            this.txtAdresBilgisi.StyleController = this.layoutControl1;
            this.txtAdresBilgisi.TabIndex = 68;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(124, 89);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(232, 22);
            this.txtAdi.StyleController = this.layoutControl1;
            this.txtAdi.TabIndex = 75;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgGenelBilgiler,
            this.lcgIletisimBilgileri,
            this.lcgAdresBilgileri,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(380, 368);
            this.Root.TextVisible = false;
            // 
            // lcgGenelBilgiler
            // 
            this.lcgGenelBilgiler.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.lcgGenelBilgiler.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem7});
            this.lcgGenelBilgiler.Location = new System.Drawing.Point(0, 0);
            this.lcgGenelBilgiler.Name = "lcgGenelBilgiler";
            this.lcgGenelBilgiler.Size = new System.Drawing.Size(360, 141);
            this.lcgGenelBilgiler.Text = "Genel Bilgiler";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtCariKodu;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(336, 26);
            this.layoutControlItem1.Text = "Cari Kodu";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtTCKimlikNo;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(336, 24);
            this.layoutControlItem3.Text = "TC Kimlik Numarası";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtAdi;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(336, 26);
            this.layoutControlItem2.Text = "Adı";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtSoyadi;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(336, 26);
            this.layoutControlItem7.Text = "Soyadı";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(88, 13);
            // 
            // lcgIletisimBilgileri
            // 
            this.lcgIletisimBilgileri.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.lcgIletisimBilgileri.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem8});
            this.lcgIletisimBilgileri.Location = new System.Drawing.Point(0, 141);
            this.lcgIletisimBilgileri.Name = "lcgIletisimBilgileri";
            this.lcgIletisimBilgileri.Size = new System.Drawing.Size(360, 90);
            this.lcgIletisimBilgileri.Text = "İletişim Bilgileri";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtTelefonNumarasi;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(336, 25);
            this.layoutControlItem4.Text = "Telefon Numarası";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtMailAdresi;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(336, 26);
            this.layoutControlItem8.Text = "Mail Adresi";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(88, 13);
            // 
            // lcgAdresBilgileri
            // 
            this.lcgAdresBilgileri.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.lcgAdresBilgileri.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9});
            this.lcgAdresBilgileri.Location = new System.Drawing.Point(0, 231);
            this.lcgAdresBilgileri.Name = "lcgAdresBilgileri";
            this.lcgAdresBilgileri.Size = new System.Drawing.Size(360, 65);
            this.lcgAdresBilgileri.Text = "Adres Bilgileri";
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtAdresBilgisi;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(336, 26);
            this.layoutControlItem9.Text = "Adres Bilgisi";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnVazgec;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 322);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(360, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnKaydet;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 296);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(360, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // frmCariKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 368);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmCariKayit.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.Name = "frmCariKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMailAdresi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdresBilgisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgGenelBilgiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgIletisimBilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAdresBilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtCariKodu;
        private System.Windows.Forms.MaskedTextBox txtTCKimlikNo;
        private System.Windows.Forms.MaskedTextBox txtTelefonNumarasi;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtSoyadi;
        private DevExpress.XtraEditors.TextEdit txtMailAdresi;
        private DevExpress.XtraEditors.TextEdit txtAdresBilgisi;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup lcgGenelBilgiler;
        private DevExpress.XtraLayout.LayoutControlGroup lcgIletisimBilgileri;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlGroup lcgAdresBilgileri;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.TextEdit txtAdi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}