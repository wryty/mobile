namespace crossproba.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private void LeaderboardPageButtonClicked(object sender, EventArgs e)
    {
        Label label = new Label();
        label.Text = "������� ����� ��� LeaderboardPage";
        aboutPageStackLayout.Add(label);
    }

}