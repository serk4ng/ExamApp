using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Core.Models
{
    public class Base
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
