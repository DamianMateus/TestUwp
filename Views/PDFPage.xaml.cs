using System;
using System.Collections.ObjectModel;
using System.IO;
using Windows.Data.Pdf;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;
using RestSharp;

namespace TestUwp.Views
{
    public sealed partial class PDFPage : Page
    {
        public ObservableCollection<BitmapImage> PdfPages
        {
            get;
            set;
        } = new ObservableCollection<BitmapImage>();


        public PDFPage()
        {
            this.InitializeComponent();
            this.DataContext = this;
        }

        public async void OpenLocal()
        {
            var client = new RestClient("https://gotocon.com/dl/goto-aar-2014/slides/JamesMontemagno_XamarinFormsNativeIOSAndroidAndWindowsPhoneAppsFromONECCodebase.pdf");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            byte[] response = client.DownloadData(request);
            var path = ApplicationData.Current.LocalFolder.Path;
            path = Path.Combine(path + "\\Pdf.pdf");
            File.WriteAllBytes(path, response);
            StorageFile f = await
            StorageFile.GetFileFromPathAsync(path);
            PdfDocument pdfDoc = await PdfDocument.LoadFromFileAsync(f);
            Load(pdfDoc);

        }

        async void Load(PdfDocument pdfDoc)
        {
            PdfPages.Clear();

            for (uint i = 0; i < pdfDoc.PageCount; i++)
            {
                BitmapImage image = new BitmapImage();
                var page = pdfDoc.GetPage(i);
                using (InMemoryRandomAccessStream stream = new InMemoryRandomAccessStream())
                {
                    await page.RenderToStreamAsync(stream);
                    await image.SetSourceAsync(stream);
                }

                PdfPages.Add(image);
            }
        }

        private void LocalPDF_Open(object sender, TappedRoutedEventArgs e)
        {
            OpenLocal();
        }
    }
}