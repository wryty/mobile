using System.ComponentModel;

namespace crossproba.Views;

public partial class StatsPage : ContentPage
{
	static public int CompletedTests { get; set; } = 0;
	static public int FailedTests { get; set; } = 0;

	public StatsPage()
	{
		InitializeComponent();
		TestPage.statsPage = this;
		UpdateCount();

    }
    
	public void UpdateCount()
	{
        labelCompleted.Text = CompletedTests.ToString();
		labelFailed.Text = FailedTests.ToString();
    }
}