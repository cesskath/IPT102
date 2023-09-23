using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Kathleen Balberan", StudentId = "21-2158", StudentAge = "21" },
            new StudentInfoModel { Name = "Karen Mae Balberan", StudentId = "00-0000", StudentAge = "27" },
            new StudentInfoModel { Name = "Josephine Balberan", StudentId = "00-0001", StudentAge = "48" },
            new StudentInfoModel { Name = "Armando Balberan", StudentId = "00-0002", StudentAge = "53" }
        };

        return View(studentInfoArray);
    }
}
