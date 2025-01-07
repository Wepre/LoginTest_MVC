using System.ComponentModel.DataAnnotations;

namespace LoginTest_MVC.Models;

public class PersonViewModel
{
    public PersonViewModel()
    {
    }

    public PersonViewModel(string username, string password)
    {
        Username = username;
        Password = password;
    }
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
    
    
}