using EFLib.Models;

namespace EFLib.Services;

public interface ITeacherService
{
    /// <summary>
    /// Create object
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    void Create(string firstName,string lastName);
    /// <summary>
    /// Update object
    /// </summary>
    /// <param name="id"></param>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    void Update(int id, string firstName,string lastName);
    /// <summary>
    /// Delete object
    /// </summary>
    /// <param name="id"></param>
    void Delete(int id);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Teacher GetById(int id);
    List<Teacher> GetAll();
}