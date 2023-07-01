using crossproba.Models;
using crossproba.ViewModels;

namespace crossproba.Views
{
    public partial class TestsListPage : ContentPage
    {
        public TestsListPage()
        {
            InitializeComponent();
            BindingContext = new TestsListViewModel();
        }

        private async void OnTestTapped(object sender, System.EventArgs e)
        {
            if (sender is TextCell textCell && textCell.BindingContext is Test selectedTest)
            {
                await Navigation.PushAsync(new TestPage(selectedTest));
            }
        }
    }
}
