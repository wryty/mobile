

namespace crossproba.Views;
public partial class MainTestPage : ContentPage
{
	public MainTestPage()
	{
		InitializeComponent();
	}

    private async void OnInformationSecurityTapped(object sender, EventArgs e)
    {

        // ������� �� �������� TestsListPage
        await Navigation.PushAsync(new TestsListPage("�������������� ������������"));
    }

    private async void OnBankSecurityTapped(object sender, EventArgs e)
    {
        // ������� �� �������� TestsListPage
        await Navigation.PushAsync(new TestsListPage("���������� ������������"));
    }
}