using LoginTest_MVC.Models;
using Microsoft.Extensions.Primitives;

namespace LoginTest_MVC.repository;

public interface IPersonRepository
{
    List<PersonViewModel> _personViewModels { get; set; }
    //改动又来了一，fixup是什么意思？fixup就是追加要提交的内容，可能上一个提交当中，是还不够完善的，可以多文件吧‘111
    
    PersonViewModel GetPersonViewModel(string  username);
    void AddPersonViewModel(StringValues username, StringValues password);
    List<PersonViewModel> GetAllPersonViewModel();
}