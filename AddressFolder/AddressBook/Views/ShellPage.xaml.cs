using AddressBook.Services;
using AddressBook.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace AddressBook.Views
{
    public sealed partial class ShellPage : Page
    {
        private ShellViewModel ViewModel { get { return DataContext as ShellViewModel; } }

        public ShellPage()
        {
            InitializeComponent();
            DataContext = ViewModel;
            ViewModel.Initialize(shellFrame);
        }
    }
}
