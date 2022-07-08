using EFLib.Models;

namespace EFLib.Services;

public interface IChildrenService
{
    /// <summary>
    /// Create object
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    void Create(string firstName,string lastName,int parentId,int teacherId);
    /// <summary>
    /// Update object
    /// </summary>
    /// <param name="id"></param>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="parentId"></param>
    /// <param name="teacherId"></param>
    void Update(int id, string firstName,string lastName,int parentId,int teacherId);
    /// <summary>
    /// Delete object
    /// </summary>
    /// <param name="id"></param>
    void Delete(int id);
    
    Children GetById(int id);
    List<Children> GetAll();
}