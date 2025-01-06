using LoginTest_MVC.Models;
using Microsoft.Extensions.Primitives;

namespace LoginTest_MVC.repository;

public interface IPersonRepository
{
    List<PersonViewModel> _personViewModels { get; set; }
    //改动又来了一
    PersonViewModel GetPersonViewModel(string  username);
    void AddPersonViewModel(StringValues username, StringValues password);
    List<PersonViewModel> GetAllPersonViewModel();
}