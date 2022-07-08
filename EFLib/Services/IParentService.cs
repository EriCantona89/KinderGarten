using EFLib.Models;

namespace EFLib.Services;

public interface IParentService
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
    /// Get ID 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Parent GetById(int id);
    /// <summary>
    /// Get List
    /// </summary>
    /// <returns></returns>
    List<Parent> GetAll();
}