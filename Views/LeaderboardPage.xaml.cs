namespace crossproba.Views;

public partial class LeaderboardPage : ContentPage
{
	public LeaderboardPage()
	{
		InitializeComponent();
	}

    private void LeaderboardPageButtonClicked(object sender, EventArgs e)
    {
        Label label = new Label();
        label.Text = "������� ����� ��� LeaderboardPage";
        leaderboardPageStackLayout.Add(label);
    }

}