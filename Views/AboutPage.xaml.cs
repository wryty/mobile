namespace crossproba.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private void OnLinkTapped(object sender, EventArgs e)
    {
        if (sender is BindableObject bindable)
        {
            if (bindable.BindingContext is Span span)
            {
                string url = span.Text;

                // Откройте ссылку в браузере
                Launcher.TryOpenAsync(new Uri(url));
            }
        }
    }

}