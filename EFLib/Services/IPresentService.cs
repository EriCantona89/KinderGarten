using EFLib.Models;

namespace EFLib.Services;

public interface IPresentService
{
    void Create(DateTime date,int childrenId,bool present);
    void Update(int id,DateTime date,int childrenId,bool presents);
    void Delete(int id);
    Present GetById(int id);
    List<Present> GetAll();
}