using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Core.Models
{
    public class Question : Base
    {
        public int ExamId { get; set; }
        public string Title { get; set; }
    }
}
