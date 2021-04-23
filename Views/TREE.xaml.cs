using System;

using TestUwp.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace TestUwp.Views
{

    public sealed partial class TREE : Page
    {
        public TREEViewModel ViewModel { get; } = new TREEViewModel();

        public TREE()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            await ViewModel.LoadDataAsync();
        }
    }
}