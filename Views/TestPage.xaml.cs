using crossproba.Models;
using crossproba.ViewModels;
using System.ComponentModel;

namespace crossproba.Views
{
    public partial class TestPage : ContentPage, INotifyPropertyChanged
    {
        private Test test;
        private TestViewModel viewModel;

        public TestPage(Test test)
        {
            InitializeComponent();
            this.test = test;
            viewModel = new TestViewModel(test);
            BindingContext = viewModel;
            ShowCurrentQuestion();
        }

        private void ShowCurrentQuestion()
        {
            var currentQuestion = test.Questions[viewModel.CurrentQuestionIndex];
            questionLabel.Text = currentQuestion.Text;
        }

        private void NextQuestionButtonClicked(object sender, System.EventArgs e)
        {
            viewModel.NextQuestion();
            ShowCurrentQuestion();

            if (viewModel.IsTestCompleted)
            {
                DisplayResult();
                progressBar.ProgressTo(1, 250, Easing.Linear);
            }
        }

        private void DisplayResult()
        {
            var resultMessage = $"Правильных ответов: {viewModel.CorrectAnswersCount}\nНеправильных ответов: {viewModel.IncorrectAnswersCount}";
            viewModel.ResultMessage = resultMessage;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
