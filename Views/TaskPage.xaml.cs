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
            // ����� ����� ���������������� ������ �������� � �������
            testQuestions = new TestQuestion[]
            {
                new TestQuestion("������ 1", "����� 1"),
                new TestQuestion("������ 2", "����� 2"),
                new TestQuestion("������ 3", "����� 3")
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
                DisplayAlert("���� �������", "�� �������� �� ��� �������.", "OK");
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
                    DisplayAlert("����� ������", "��� ����� ������.", "OK");
                }
                else
                {
                    DisplayAlert("����� ��������", "��� ����� ��������.", "OK");
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
