using System;

using TestUwp.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace TestUwp.Views
{
    public sealed partial class TEXTPage : Page
    {
        public TEXTViewModel ViewModel { get; } = new TEXTViewModel();

        public TEXTPage()
        {
            this.InitializeComponent();
            

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Browser.Navigate(new Uri("ms-appx-web:///local/Text.html"));
        }

    }
}

