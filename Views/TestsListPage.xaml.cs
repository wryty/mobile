using crossproba.Models;
using crossproba.ViewModels;

namespace crossproba.Views
{
    public partial class TestsListPage : ContentPage
    {
        public string Category { get; set; }
        public TestsListPage(string category)
        {
            Category = category;
            InitializeComponent();
            BindingContext = new TestsListViewModel(category);
        }
        private async void OnTestTapped(object sender, SelectionChangedEventArgs e)
        {
           await Navigation.PushAsync(new TestPage(e.CurrentSelection.FirstOrDefault() as Test));
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            Page lessonPage;
            if (Category == "Информационная безопасность")
            {
                lessonPage = new LessonIS();
            }
            else
            {
                lessonPage = new LessonBS();
            }

            await Navigation.PushAsync(lessonPage);
        }
    }
}
