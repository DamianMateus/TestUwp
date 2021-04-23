using System;

using TestUwp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace TestUwp.Views
{
    public sealed partial class TEXTPage : Page
    {
        public TEXTViewModel ViewModel { get; } = new TEXTViewModel();

        public TEXTPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
