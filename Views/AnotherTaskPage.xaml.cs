namespace crossproba.Views;

public partial class AnotherTaskPage : ContentPage
{
    public AnotherTaskPage()
    {
        InitializeComponent();
    }

    private void AnotherTaskPageButtonClicked(object sender, EventArgs e)
    {
        Label label = new Label();
        label.Text = "Пробный текст для AccountPage";
        anotherTaskPageStackLayout.Add(label);

    }
}