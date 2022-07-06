using EFLib.Models;

namespace EFLib.Services;

public interface IParentService
{
    void Create(string firstName,string lastName);
    void Update(int id, string firstName,string lastName);
    void Delete(int id);
    Parent GetById(int id);
    List<Parent> GetAll();
}