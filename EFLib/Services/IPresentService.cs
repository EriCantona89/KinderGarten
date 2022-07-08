using EFLib.Models;

namespace EFLib.Services;

public interface IPresentService
{
    /// <summary>
    /// Create object
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    void Create(DateTime date,int childrenId,bool present);
    
    /// <summary>
    /// Update object
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    void Update(int id,DateTime date,int childrenId,bool presents);
    
    /// <summary>
    /// Delete object
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    void Delete(int id);
    Present GetById(int id);
    List<Present> GetAll();
}