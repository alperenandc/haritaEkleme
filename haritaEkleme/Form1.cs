using System;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace haritaEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        private void Form1_Load(object sender, EventArgs e)
{
    // Form yüklendiğinde çalışacak kodlar buraya
    MessageBox.Show("Form yüklendi!");
}


        private void btnKonumAl_Click(object sender, EventArgs e)
        {
            // Konum bilgilerini girin veya bir API'den alın
            double latitude = 40.741895;  // Örnek: İstanbul
            double longitude = 29.008333;

            // HTML dosyasını okuma
            string htmlFilePath = @"C:\Users\CASPER\Desktop\harita\map.html";
            string htmlContent = File.ReadAllText(htmlFilePath);

            // Konum bilgilerini HTML içine yerleştirin
            string script = $"<script>initMap({latitude}, {longitude});</script>";
            string finalContent = htmlContent.Replace("</body>", script + "</body>");

            // HTML'yi WebView2'ye yükle
            webView21.NavigateToString(finalContent);
        }
    }
}
