

namespace crossproba.Views;
public partial class MainTestPage : ContentPage
{
	public MainTestPage()
	{
		InitializeComponent();
	}

    private async void OnInformationSecurityTapped(object sender, EventArgs e)
    {

        // Перейти на страницу TestsListPage
        await Navigation.PushAsync(new TestsListPage("Информационная безопасность"));
    }

    private async void OnBankSecurityTapped(object sender, EventArgs e)
    {
        // Перейти на страницу TestsListPage
        await Navigation.PushAsync(new TestsListPage("Банковская безопасность"));
    }
}