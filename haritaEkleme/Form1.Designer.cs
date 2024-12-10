namespace haritaEkleme
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button btnKonumAl;

        /// <summary>
        /// Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        /// <param name="disposing">Yönetilen kaynakları atmak için true; aksi halde false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Bileşenleri başlatır.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnKonumAl = new System.Windows.Forms.Button();

            // Form Ayarları
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Harita Ekleme";
            this.Load += new System.EventHandler(this.Form1_Load);

            // WebView2 Ayarları
            this.webView21.Location = new System.Drawing.Point(12, 12);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(760, 360);
            this.webView21.Source = null; // Başlangıçta boş
            this.webView21.ZoomFactor = 1.0;

            // Buton Ayarları
            this.btnKonumAl.Location = new System.Drawing.Point(12, 380);
            this.btnKonumAl.Name = "btnKonumAl";
            this.btnKonumAl.Size = new System.Drawing.Size(100, 40);
            this.btnKonumAl.Text = "Konum Al";
            this.btnKonumAl.UseVisualStyleBackColor = true;
            this.btnKonumAl.Click += new System.EventHandler(this.btnKonumAl_Click);

            // Form'a Bileşen Ekleme
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.btnKonumAl);

            // Form Son Ayarları
            this.ResumeLayout(false);
        }
    }
}
