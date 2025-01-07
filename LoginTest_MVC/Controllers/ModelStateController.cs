using LoginTest_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginTest_MVC.Controllers;

public class ModelStateController : Controller
{
    // GET
    public IActionResult Index()
    {
        Console.WriteLine("ModelState_get");
        // var model = new PersonViewModel();
        // model.Username = "finnian";
        // model.Password = "finnian";
        return View();
       
    }

    [HttpPost]
    public IActionResult Index(PersonViewModel model)
    {
        Console.WriteLine("ModelState_post");
        var a = 1;
        if (a==1)
        {
            return Redirect($"Home/Index/");
        }
        return View(model);
    }
}