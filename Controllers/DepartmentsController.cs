using Microsoft.AspNetCore.Mvc;

namespace LessonOne
{
  public class DepartmentsController : Controller
  {
    public IActionResult Index()
    {
      List<Dictionary<string, object>> data = new() 
      {
        new() { { "id", "1" }, { "Name", "Fruits & Veg" } },
        new() { { "id", "2" }, { "Name", "Meats" } },
        new() { { "id", "3" }, { "Name", "Sweets & Treats" } }
      };

      return View(data);
    }
  }
}