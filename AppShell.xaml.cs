using System.Windows.Input;
using crossproba.Views;
namespace crossproba;

public partial class AppShell : Shell
{

    public Dictionary<string, Type> Routes { get; private set; } = new Dictionary<string, Type>();
    public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
    public AppShell()
	{
		InitializeComponent();
		RegisterRoutes();
	}


    void RegisterRoutes()
    {
        Routes.Add("task", typeof(MainTestPage));
        Routes.Add("about", typeof(AboutPage));

        foreach (var item in Routes)
        {
            Routing.RegisterRoute(item.Key, item.Value);
        }
    }

}
