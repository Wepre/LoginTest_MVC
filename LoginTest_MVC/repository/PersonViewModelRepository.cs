using LoginTest_MVC.Models;
using Microsoft.Extensions.Primitives;

namespace LoginTest_MVC.repository;

public class PersonViewModelRepository : IPersonRepository
{
    public List<PersonViewModel> _personViewModels { get; set; }

    public PersonViewModelRepository()
    {
        PersonViewModel p1 = new PersonViewModel(username: "1", password: "1");
        PersonViewModel p2 = new PersonViewModel(username: "2", password: "2");
        PersonViewModel p3 = new PersonViewModel(username: "3", password: "3");
        PersonViewModel p4 = new PersonViewModel(username: "4", password: "4");
        _personViewModels = new List<PersonViewModel?>() { p1, p2, p3, p4 };
    }


    public PersonViewModel? GetPersonViewModel(string username)
    {
        return _personViewModels.FirstOrDefault(x => x.Username == username);
    }
    // fixup是什么意思？fixup就是追加要提交的内容，可能上一个提交当中，是还不够完善的，可以多文件吧‘11

    //改动了第二个的二二

    public void AddPersonViewModel(StringValues username, StringValues password)
    {
        _personViewModels.Add(new PersonViewModel(username: username, password: password));
        
    }

    public List<PersonViewModel> GetAllPersonViewModel()
    {
        return _personViewModels;
    }

    public PersonViewModel GetPersonViewModel(string username, string password)
    {
        return _personViewModels.Where(e => e.Password == password && e.Username == username).FirstOrDefault();
    }
}