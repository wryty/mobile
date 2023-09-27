using crossproba.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace crossproba.ViewModels
{
    public class TestViewModel : INotifyPropertyChanged
    {
        private Test test;
        private int currentQuestionIndex;
        private List<Answer> answers;
        private Answer selectedAnswer;
        private string resultMessage;
        private double progress;
        


        public double Progress
        {
            get => progress;
            set
            {
                progress = value;
                OnPropertyChanged(nameof(Progress));
            }
        }

        public int CurrentQuestionIndex
        {
            get => currentQuestionIndex;
            set
            {
                currentQuestionIndex = value;
                OnPropertyChanged(nameof(CurrentQuestionIndex));
                OnPropertyChanged(nameof(CanMoveToNextQuestion));
            }
        }

        private double CalculateProgress()
        {
            return (double)(CurrentQuestionIndex + 1) / test.Questions.Count;
        }

        public List<Answer> Answers
        {
            get => answers;
            set
            {
                answers = value;
                OnPropertyChanged(nameof(Answers));
            }
        }

        public Answer SelectedAnswer
        {
            get => selectedAnswer;
            set
            {
                selectedAnswer = value;
                OnPropertyChanged(nameof(SelectedAnswer));
            }
        }
        private Color currentBackgroundColor;
        public Color CurrentBackgroundColor
        {
            get { return currentBackgroundColor; }
            set { currentBackgroundColor = value; }
        }
        bool papa = true;
        public bool CanMoveToNextQuestion => CurrentQuestionIndex < test.Questions.Count && papa;

        public int CorrectAnswersCount { get; private set; }
        public int IncorrectAnswersCount { get; private set; }

        public bool IsTestCompleted => CurrentQuestionIndex >= test.Questions.Count - 1;

        public string ResultMessage
        {
            get => resultMessage;
            set
            {
                resultMessage = value;
                OnPropertyChanged(nameof(ResultMessage));
            }
        }

        public TestViewModel(Test test)
        {
            this.test = test;
            Initialize();
            Progress = CalculateProgress();

            CurrentBackgroundColor = test.Category == "Информационная безопасность" ? Color.FromArgb("#D6ACF6") : Color.FromArgb("#63D4A9");
        }

        private void Initialize()
        {
            CurrentQuestionIndex = 0;
            CorrectAnswersCount = 0;
            IncorrectAnswersCount = 0;
            ResultMessage = string.Empty;

            LoadAnswers();
        }

        private void LoadAnswers()
        {
            var question = test.Questions[CurrentQuestionIndex];
            Answers = question.Options;
        }

        public void NextQuestion()
        {
            CheckAnswer();

            if (IsTestCompleted)
            {
                SelectedAnswer = null;
                papa = false;
            }
            else
            {
                CurrentQuestionIndex++;
                LoadAnswers();
                SelectedAnswer = null;
                Progress = CalculateProgress();
            }
            OnPropertyChanged(nameof(CanMoveToNextQuestion));
        }

        private void CheckAnswer()
        {
            var question = test.Questions[CurrentQuestionIndex];
            var selectedAnswers = Answers.Where(a => a.IsSelected).ToList();

            bool allCorrect = true;

            foreach (var correctAnswerIndex in question.CorrectAnswers)
            {
                if (!selectedAnswers.Any(a => a == question.Options[correctAnswerIndex]))
                {
                    allCorrect = false;
                    break;
                }
            }
            if (allCorrect && selectedAnswers.Count == question.CorrectAnswers.Count)
            {
                CorrectAnswersCount++;
            }
            else
            {
                IncorrectAnswersCount++;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
