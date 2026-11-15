using Microsoft.AspNetCore.Mvc;

namespace PRELIM_A1.Models
{
    public class ExamViewModel
    {
        public string ExamTitle { get; set; } = "PRELIM A1";
        public int TotalQuestions { get; set; }
        public List<Question> Questions { get; set; } = new();
    }
}
