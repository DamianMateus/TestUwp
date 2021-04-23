//using System;

//using TestUwp.ViewModels;
//using Windows.Storage;
//using Windows.UI.Xaml.Controls;

//namespace TestUwp.Views
//{
//    public sealed partial class PDFPage : Page
//    {
//        public PDFViewModel ViewModel { get; } = new PDFViewModel();

//        public PDFPage()
//        {
//            Uri source = new Uri(selectedfile.DocumentPath);
//            StorageFile destinationFile = await KnownFolders.PicturesLibrary.CreateFileAsync(
//            selectedfile.DocumentName, CreationCollisionOption.GenerateUniqueName);
//            BackgroundDownloader downloader = new BackgroundDownloader();
//            DownloadOperation download = downloader.CreateDownload(source, destinationFile);
//            InitializeComponent();
//        }
//    }
//}
