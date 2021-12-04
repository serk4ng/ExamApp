namespace ExamApp.UI.Dto
{
    public class ExamCheckViewModel
    {
        public int Id { get; set; }
        public byte Question1Answer { get; set; }
        public byte Question2Answer { get; set; }
        public byte Question3Answer { get; set; }
        public byte Question4Answer { get; set; }


        public byte Question1UserAnswer { get; set; }
        public byte Question2UserAnswer { get; set; }
        public byte Question3UserAnswer { get; set; }
        public byte Question4UserAnswer { get; set; }
    }
}
