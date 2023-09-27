﻿using System.Collections.Generic;

namespace crossproba.Models
{
    public class Test
    {
        public string Name { get; set; }
        public List<Question> Questions { get; set; }
        public string Category { get; set; }

        public Test(string name, List<Question> questions, string category)
        {
            Name = name;
            Questions = questions;
            Category = category; 
        }
    }

    public class Question
    {
        public string Text { get; set; }
        public List<Answer> Options { get; set; }
        public List<int> CorrectAnswers { get; set; }
    }

    public class Answer
    {
        public string Text { get; set; }
        public bool IsSelected { get; set; }
        public bool IsCorrect { get; set; }
    }
}