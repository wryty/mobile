using crossproba.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace crossproba.ViewModels
{
    public class TestsListViewModel : BaseViewModel
    {
        private ObservableCollection<Test> tests;
        public ObservableCollection<Test> Tests
        {
            get { return tests; }
            set { SetProperty(ref tests, value); }
        }

        private Test selectedTest;
        public Test SelectedTest
        {
            get { return selectedTest; }
            set { SetProperty(ref selectedTest, value); }
        }

        public ICommand TestSelectedCommand { get; }

        public TestsListViewModel()
        {
            InitializeTests();

            TestSelectedCommand = new Command(OnTestSelected);
        }

        private async void OnTestSelected()
        {
            if (SelectedTest != null)
            {
                // Выполните необходимые действия при выборе теста, например, переход на страницу TestPage
                await Application.Current.MainPage.DisplayAlert("Выбран тест", SelectedTest.Name, "OK");
            }
        }

        private void InitializeTests()
        {
            Tests = new ObservableCollection<Test>()
            {
                new Test("Тест 1", new List<Question>
                {
                    new Question
                    {
                        Text = "Вопрос 1",
                        Options = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "Вариант 1",
                                IsSelected = false,
                                IsCorrect = true
                            },
                            new Answer
                            {
                                Text = "Вариант 2",
                                IsSelected = false,
                                IsCorrect = false
                            },
                            new Answer
                            {
                                Text = "Вариант 3",
                                IsSelected = false,
                                IsCorrect = false
                            }
                        },
                        CorrectAnswers = new List<int> { 0 }
                    },
                    new Question
                    {
                        Text = "Вопрос 2",
                        Options = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "Вариант 1",
                                IsSelected = false,
                                IsCorrect = false
                            },
                            new Answer
                            {
                                Text = "Вариант 2",
                                IsSelected = false,
                                IsCorrect = true
                            },
                            new Answer
                            {
                                Text = "Вариант 3",
                                IsSelected = false,
                                IsCorrect = false
                            }
                        },
                        CorrectAnswers = new List<int> { 1 }
                    },
                    new Question
                    {
                        Text = "Вопрос 3",
                        Options = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "Вариант 1",
                                IsSelected = false,
                                IsCorrect = false
                            },
                            new Answer
                            {
                                Text = "Вариант 2",
                                IsSelected = false,
                                IsCorrect = false
                            },
                            new Answer
                            {
                                Text = "Вариант 3",
                                IsSelected = false,
                                IsCorrect = true
                            }
                        },
                        CorrectAnswers = new List<int> { 2 }
                    }
                }),
                new Test("Тест 2", new List<Question>
                {
                    new Question
                    {
                        Text = "Вопрос 1",
                        Options = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "Вариант 1",
                                IsSelected = false,
                                IsCorrect = false
                            },
                            new Answer
                            {
                                Text = "Вариант 2",
                                IsSelected = false,
                                IsCorrect = true
                            },
                            new Answer
                            {
                                Text = "Вариант 3",
                                IsSelected = false,
                                IsCorrect = false
                            }
                        },
                        CorrectAnswers = new List<int> { 1 }
                    },
                    new Question
                    {
                        Text = "Вопрос 2",
                        Options = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "Вариант 1",
                                IsSelected = false,
                                IsCorrect = true
                            },
                            new Answer
                            {
                                Text = "Вариант 2",
                                IsSelected = false,
                                IsCorrect = false
                            },
                            new Answer
                            {
                                Text = "Вариант 3",
                                IsSelected = false,
                                IsCorrect = false
                            }
                        },
                        CorrectAnswers = new List<int> { 0 }
                    },
                    new Question
                    {
                        Text = "Вопрос 3",
                        Options = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "Вариант 1",
                                IsSelected = false,
                                IsCorrect = false
                            },
                            new Answer
                            {
                                Text = "Вариант 2",
                                IsSelected = false,
                                IsCorrect = false
                            },
                            new Answer
                            {
                                Text = "Вариант 3",
                                IsSelected = false,
                                IsCorrect = true
                            }
                        },
                        CorrectAnswers = new List<int> { 2 }
                    },
                    new Question
                    {
                        Text = "Вопрос 4",
                        Options = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "Вариант 1",
                                IsSelected = false,
                                IsCorrect = false
                            },
                            new Answer
                            {
                                Text = "Вариант 2",
                                IsSelected = false,
                                IsCorrect = true
                            },
                            new Answer
                            {
                                Text = "Вариант 3",
                                IsSelected = false,
                                IsCorrect = false
                            }
                        },
                        CorrectAnswers = new List<int> { 1 }
                    }
                }),
                new Test("Тест 3", new List<Question>
                {
                    new Question
                    {
                        Text = "Вопрос 1",
                        Options = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "Вариант 1",
                                IsSelected = false,
                                IsCorrect = true
                            },
                            new Answer
                            {
                                Text = "Вариант 2",
                                IsSelected = false,
                                IsCorrect = false
                            },
                            new Answer
                            {
                                Text = "Вариант 3",
                                IsSelected = false,
                                IsCorrect = false
                            }
                        },
                        CorrectAnswers = new List<int> { 0 }
                    },
                    new Question
                    {
                        Text = "Вопрос 2",
                        Options = new List<Answer>
                        {
                            new Answer
                            {
                                Text = "Вариант 1",
                                IsSelected = false,
                                IsCorrect = false
                            },
                            new Answer
                            {
                                Text = "Вариант 2",
                                IsSelected = false,
                                IsCorrect = true
                            },
                            new Answer
                            {
                                Text = "Вариант 3",
                                IsSelected = false,
                                IsCorrect = false
                            }
                        },
                        CorrectAnswers = new List<int> { 1 }
                    }
                })
            };
        }
    }
}
