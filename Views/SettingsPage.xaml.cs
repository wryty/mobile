namespace crossproba.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}


	private void SettingsPageButtonClicked(object sender, EventArgs e)
	{
		Label label = new Label();
		label.Text = "������� ����� ��� SettingsPage";
		settingsPageStackLayout.Add(label);
    }
}