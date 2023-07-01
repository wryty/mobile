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

        public bool CanMoveToNextQuestion => CurrentQuestionIndex < test.Questions.Count - 1;

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
            CurrentQuestionIndex++;

            if (!IsTestCompleted)
            {
                LoadAnswers();
                SelectedAnswer = null;
                Progress = CalculateProgress();
            }
        }

        private void CheckAnswer()
        {
            if (SelectedAnswer != null && SelectedAnswer.IsSelected && SelectedAnswer.IsCorrect)
            {
                CorrectAnswersCount++;
            }
            else if (SelectedAnswer != null && SelectedAnswer.IsSelected && !SelectedAnswer.IsCorrect)
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
