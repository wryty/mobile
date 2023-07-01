using System;

namespace crossproba.Views
{
    public partial class TaskPage : ContentPage
    {
        private TestQuestion[] testQuestions;
        private int currentQuestionIndex;

        public TaskPage()
        {
            InitializeComponent();
            InitializeTestQuestions();
            ShowNextQuestion();
        }

        private void InitializeTestQuestions()
        {
            // Здесь можно инициализировать список вопросов и ответов
            testQuestions = new TestQuestion[]
            {
                new TestQuestion("Вопрос 1", "Ответ 1"),
                new TestQuestion("Вопрос 2", "Ответ 2"),
                new TestQuestion("Вопрос 3", "Ответ 3")
            };
        }

        private void ShowNextQuestion()
        {
            if (currentQuestionIndex < testQuestions.Length)
            {
                TestQuestion currentQuestion = testQuestions[currentQuestionIndex];
                questionLabel.Text = currentQuestion.Question;
                questionLabel.IsVisible = true;
                answerEntry.IsVisible = true;
                answerButton.IsEnabled = true;
            }
            else
            {
                DisplayAlert("Тест окончен", "Вы ответили на все вопросы.", "OK");
                questionLabel.IsVisible = false;
                answerEntry.IsVisible = false;
                answerButton.IsEnabled = false;
            }
        }

        private void TaskPageButtonClicked(object sender, EventArgs e)
        {
            ShowNextQuestion();
        }

        private void AnswerButtonClicked(object sender, EventArgs e)
        {
            if (currentQuestionIndex < testQuestions.Length)
            {
                TestQuestion currentQuestion = testQuestions[currentQuestionIndex];
                string userAnswer = answerEntry.Text;

                if (userAnswer == currentQuestion.Answer)
                {
                    DisplayAlert("Ответ верный", "Ваш ответ верный.", "OK");
                }
                else
                {
                    DisplayAlert("Ответ неверный", "Ваш ответ неверный.", "OK");
                }

                currentQuestionIndex++;
                answerEntry.Text = string.Empty;
                ShowNextQuestion();
            }
        }
    }

    public class TestQuestion
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public TestQuestion(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }
    }
}
