using LoginTest_MVC.Models;

namespace LoginTest_MVC.repository;

public interface IPersonRepository
{
    List<PersonViewModel> _personViewModels { get; set; }
    PersonViewModel GetPersonViewModel(string  username);
}