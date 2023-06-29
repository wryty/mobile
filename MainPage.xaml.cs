
namespace crossproba;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}



    private async void AnotherButtonClicked(object sender, EventArgs e)
    {
		bool answer = await DisplayAlert("Вопрос!","Хотите ли вы кушать?", "Да", "Нет");
		if (answer)
		{
			HelloText.Text = "Кушать подано!";
		}
		else
		{
            HelloText.Text = "Покушаете потом!";
		}
		Label label = new Label
		{

			Text = "Приветик",
			HorizontalOptions = Microsoft.Maui.Controls.LayoutOptions.Center,
			
		};
		MainStackLayout.Add(label);
		
    }
}

