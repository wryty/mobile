namespace crossproba.Views;

public partial class AccountPage : ContentPage
{
	public AccountPage()
	{
		InitializeComponent();
	}

	private void AccountPageButtonClicked(object sender, EventArgs e)
	{
		Label label = new Label();
		label.Text = "Пробный текст для AccountPage";
		accountPageStackLayout.Add(label);
		
	}
}