using PRELIM_A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace PRELIM_A1.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            var questions = ExamData.GetQuestions();

            var model = new ExamViewModel
            {
                ExamTitle = "Prelim A1",
                TotalQuestions = questions.Count,
                Questions = questions
            };

            return View(model);
        }
    }
}
