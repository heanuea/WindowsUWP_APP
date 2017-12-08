using AddressBook.Models;
using AddressBook.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace AddressBook.Views
{
    public sealed partial class CustomerDetailPage : Page
    {
        private CustomerDetailViewModel ViewModel
        {
            get { return DataContext as CustomerDetailViewModel; }
        }

        public CustomerDetailPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            ViewModel.Item = e.Parameter as Customer;
        }
    }
}
