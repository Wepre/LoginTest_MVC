using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LoginTest_MVC.Models;
using LoginTest_MVC.repository;

namespace LoginTest_MVC.Controllers;

public class HomeController : Controller
{
    // 定义一个ILogger接口的实例
    private readonly ILogger<HomeController> _logger;
    // 定义一个PersonViewModelRepository接口的实例
    private PersonViewModelRepository _personViewModelRepository;
    // 定义一个IPersonRepository接口的实例
    private IPersonRepository _iPersonRepository;

    // 构造函数，注入ILogger接口和IPersonRepository接口
    public HomeController(ILogger<HomeController> logger,IPersonRepository PersonViewModelRepository)
    {
        _logger = logger;
        // _iPersonRepository = IPersonRepository;
        _personViewModelRepository = PersonViewModelRepository as PersonViewModelRepository;
    }
    // 返回Index视图
    public IActionResult Index()
    {
        return View();
    }public IActionResult StuList()
    {
        // 调用IPersonRepository接口的GetAllPersonViewModel方法
        var allPersonViewModel = _personViewModelRepository.GetAllPersonViewModel();
        ViewBag.Persons = allPersonViewModel;
        return View();
    }


    // 返回Login视图
    [HttpGet]
    public IActionResult Login()
    {
        // 获取请求的方法
        var requestMethod = Request.Method;
        Console.WriteLine(requestMethod);
        if (requestMethod == "POST")
        {
            // 这里就说明是表单里面传过来的数据
            var formCollection = Request.Form;
            
        }
        else
        {
        }

        return View();
    }

    [HttpPost]
    public IActionResult Login(PersonViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        var Username = model.Username;
        var Password = model.Password;
        // 调用PersonViewModelRepository接口的GetPersonViewModel方法
        PersonViewModel person = _personViewModelRepository.GetPersonViewModel(Username,Password);
        Console.WriteLine(person);
        if (person == null)
        {
            Console.WriteLine("登录失败");
            ModelState.AddModelError("", "用户名或密码错误");
        }
        else
        {
            return Redirect("StuList");
        }

        return View();
    }

    // 返回Register视图

    public IActionResult Register()
    {
        if (Request.Method == "POST")
        {
            var formCollection = Request.Form;
            if (formCollection["Password"] != formCollection["Password2"])
            {
                Console.WriteLine("两次密码不一致");
                ViewBag.Error = "两次密码不一致";
                return View();
            }
            // 调用PersonViewModelRepository接口的AddPersonViewModel方法

            _personViewModelRepository.AddPersonViewModel(formCollection["Username"], formCollection["Password"]);
            Console.WriteLine("注册成功");
            ViewBag.Success = "true";
            return View();
        }

        return View();
    // 返回Privacy视图
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