using LoginTest_MVC.Models;
using Microsoft.Extensions.Primitives;

namespace LoginTest_MVC.repository;

public class PersonViewModelRepository : IPersonRepository
{
    public List<PersonViewModel> _personViewModels { get; set; }

    public PersonViewModelRepository()
    {
        PersonViewModel p1 = new PersonViewModel() { Username = "1", Password = "1" };
        PersonViewModel p2 = new PersonViewModel() { Username = "2", Password = "2" };
        PersonViewModel p3 = new PersonViewModel() { Username = "3", Password = "3" };
        PersonViewModel p4 = new PersonViewModel() { Username = "4", Password = "4" };
        _personViewModels = new List<PersonViewModel?>() { p1, p2, p3, p4 };
    }


    public PersonViewModel? GetPersonViewModel(string username)
    {
        return _personViewModels.FirstOrDefault(x => x.Username == username);
    }

    //改动二

    public void AddPersonViewModel(StringValues username, StringValues password)
    {
        _personViewModels.Add(new PersonViewModel
        {
            Username = username,
            Password = password,
        });
        
    }

    public List<PersonViewModel> GetAllPersonViewModel()
    {
        return _personViewModels;
    }
}