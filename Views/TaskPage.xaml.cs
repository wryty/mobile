namespace crossproba.Views;

public partial class TaskPage : ContentPage
{
	public TaskPage()
	{
		InitializeComponent();
	}

	private void TaskPageButtonClicked(object sender, EventArgs e)
	{
		Label label = new Label();
		label.Text = "������� ����� ��� TaskPage";
		taskPageStackLayout.Add(label);
	}
}