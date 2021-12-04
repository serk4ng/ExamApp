namespace ExamApp.UI.Dto
{
    public class ExamCreateViewModel
    {
        public int Id { get; set; }
        public string ExamTitle { get; set; }
        public string ExamDescription { get; set; }

        public string QuestionTitle1 { get; set; }
        public string QuestionOption1A { get; set; }
        public string QuestionOption1B { get; set; }
        public string QuestionOption1C { get; set; }
        public string QuestionOption1D { get; set; }
        public byte Question1Answer { get; set; }
        public byte Question1UserAnswer { get; set; }

        public string QuestionTitle2 { get; set; }
        public string QuestionOption2A { get; set; }
        public string QuestionOption2B { get; set; }
        public string QuestionOption2C { get; set; }
        public string QuestionOption2D { get; set; }
        public byte Question2Answer { get; set; }
        public byte Question2UserAnswer { get; set; }

        public string QuestionTitle3 { get; set; }
        public string QuestionOption3A { get; set; }
        public string QuestionOption3B { get; set; }
        public string QuestionOption3C { get; set; }
        public string QuestionOption3D { get; set; }
        public byte Question3Answer { get; set; }
        public byte Question3UserAnswer { get; set; }

        public string QuestionTitle4 { get; set; }
        public string QuestionOption4A { get; set; }
        public string QuestionOption4B { get; set; }
        public string QuestionOption4C { get; set; }
        public string QuestionOption4D { get; set; }
        public byte Question4Answer { get; set; }
        public byte Question4UserAnswer { get; set; }

    }
}
