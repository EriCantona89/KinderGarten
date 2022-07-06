using EFLib.Models;

namespace EFLib.Services;

public interface ITeacherService
{
    void Create(string firstName,string lastName);
    void Update(int id, string firstName,string lastName);
    void Delete(int id);
    Teacher GetById(int id);
    List<Teacher> GetAll();
}