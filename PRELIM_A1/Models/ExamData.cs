using Microsoft.AspNetCore.Mvc;

namespace PRELIM_A1.Models
{
    public static class ExamData
    {
        // SelectedAnswer holds the correct letter so it shows highlighted on the card.
        public static List<Question> GetQuestions()
        {
            return new List<Question>
            {
                new Question
                {
                    Number = 1,
                    SelectedAnswer = "B",
                    Text = "What is the fundamental difference between Server-Side Rendering (SSR/MVC) and a Decoupled Web API architecture?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "SSR returns JSON payloads, whereas a Web API compiles .cshtml Razor views on the server." },
                        new Choice { Letter = "B", Text = "SSR compiles HTML views on the server and sends fully rendered markup to the browser, whereas a Web API acts as a stateless data provider returning raw JSON." },
                        new Choice { Letter = "C", Text = "SSR only works with mobile applications, whereas Web APIs are restricted to desktop web browsers." },
                        new Choice { Letter = "D", Text = "SSR requires client-side routing in React, whereas Web APIs manage HTML layouts directly on the server." },
                    }
                },
                new Question
                {
                    Number = 2,
                    SelectedAnswer = "B",
                    Text = "Why do Web API controllers in ASP.NET Core inherit from ControllerBase instead of Controller?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "ControllerBase supports Razor View rendering using View() and ViewData." },
                        new Choice { Letter = "B", Text = "ControllerBase provides essential HTTP handling and routing without carrying unnecessary HTML view rendering overhead." },
                        new Choice { Letter = "C", Text = "Controller is obsolete in .NET 8 and cannot handle HTTP POST requests." },
                        new Choice { Letter = "D", Text = "ControllerBase automatically creates SQLite database files on application startup." },
                    }
                },
                new Question
                {
                    Number = 3,
                    SelectedAnswer = "C",
                    Text = "Which framework attribute automatically triggers an HTTP 400 Bad Request response when incoming request payloads fail structural model validation?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "[Route]" },
                        new Choice { Letter = "B", Text = "[HttpGet]" },
                        new Choice { Letter = "C", Text = "[ApiController]" },
                        new Choice { Letter = "D", Text = "[FromQuery]" },
                    }
                },
                new Question
                {
                    Number = 4,
                    SelectedAnswer = "B",
                    Text = "Which HTTP status code should an API return after successfully creating a new resource via a POST request, along with a Location header pointing to the new URI?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "200 OK" },
                        new Choice { Letter = "B", Text = "201 Created" },
                        new Choice { Letter = "C", Text = "204 No Content" },
                        new Choice { Letter = "D", Text = "404 Not Found" },
                    }
                },
                new Question
                {
                    Number = 5,
                    SelectedAnswer = "C",
                    Text = "When a DELETE request successfully removes a resource from the server and returns no content in the response body, which HTTP status code is standard?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "200 OK" },
                        new Choice { Letter = "B", Text = "201 Created" },
                        new Choice { Letter = "C", Text = "204 No Content" },
                        new Choice { Letter = "D", Text = "400 Bad Request" },
                    }
                },
                new Question
                {
                    Number = 6,
                    SelectedAnswer = "B",
                    Text = "Which of the following endpoint URIs follows RESTful resource-oriented naming best practices?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "GET /api/getAllCourses" },
                        new Choice { Letter = "B", Text = "GET /api/courses" },
                        new Choice { Letter = "C", Text = "POST /api/createNewCourseRecord" },
                        new Choice { Letter = "D", Text = "POST /api/deleteCourseById?id=5" },
                    }
                },
                new Question
                {
                    Number = 7,
                    SelectedAnswer = "B",
                    Text = "What is the primary function of the [Route(\"api/[controller]\")] attribute in ASP.NET Core?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "It connects the controller directly to an Entity Framework database context." },
                        new Choice { Letter = "B", Text = "It maps incoming URI request paths to the controller class using the class name token." },
                        new Choice { Letter = "C", Text = "It encrypts all incoming JSON payloads." },
                        new Choice { Letter = "D", Text = "It enables Cross-Origin Resource Sharing (CORS) for external React apps." },
                    }
                },
                new Question
                {
                    Number = 8,
                    SelectedAnswer = "C",
                    Text = "Which HTTP verb is safe and idempotent, intended exclusively for retrieving resource data without altering server state?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "POST" },
                        new Choice { Letter = "B", Text = "PUT" },
                        new Choice { Letter = "C", Text = "GET" },
                        new Choice { Letter = "D", Text = "DELETE" },
                    }
                },
            };
        }
    }
}
