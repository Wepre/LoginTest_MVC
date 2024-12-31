using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LoginTest_MVC.Models;
using LoginTest_MVC.repository;

namespace LoginTest_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private PersonViewModelRepository _personViewModelRepository;
    private IPersonRepository _iPersonRepository;

    public HomeController(ILogger<HomeController> logger, IPersonRepository IPersonRepository)
    {
        _logger = logger;
        _iPersonRepository = IPersonRepository;
    }

    public IActionResult Index()
    {
        return View();
    }


    public IActionResult Login()
    {
        var requestMethod = Request.Method;
        Console.WriteLine(requestMethod);
        if (requestMethod == "POST")
        {
            // 这里就说明是表单里面传过来的数据
            var formCollection = Request.Form;
            var Username = formCollection["Username"];
            var Password = formCollection["Password"];
            PersonViewModel person = _personViewModelRepository.GetPersonViewModel(Username);
            Console.WriteLine(person);
            if (person == null)
            {
                Console.WriteLine("登录失败");
            }
        }
        else
        {
        }

        return View();
    }


    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}