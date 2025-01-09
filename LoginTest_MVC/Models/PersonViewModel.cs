using System.ComponentModel.DataAnnotations;

namespace LoginTest_MVC.Models;

public class PersonViewModel
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
    public PersonViewModel(string username, string password)
    {
        Username = username;
        Password = password;
    }
}