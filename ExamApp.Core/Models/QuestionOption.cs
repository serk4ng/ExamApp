using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Core.Models
{
    public class QuestionOption : Base
    {
        public int QuestionId { get; set; }
        public string Option { get; set; }
        public string Title { get; set; }
        public bool IsCorrect { get; set; }
    }
}
