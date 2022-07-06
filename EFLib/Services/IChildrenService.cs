using EFLib.Models;

namespace EFLib.Services;

public interface IChildrenService
{
    void Create(string firstName,string lastName,int parentId,int teacherId);
    void Update(int id, string firstName,string lastName,int parentId,int teacherId);
    void Delete(int id);
    Children GetById(int id);
    List<Children> GetAll();
}