using EFLib.Models;
using Microsoft.EntityFrameworkCore;

namespace EFLib.Services;

public class PresentService
{
    private readonly AppDbContext _context;
    public PresentService()
    {
        _context = new AppDbContextFactory().CreateDbContext();
    }
    
    public void Create(DateTime date,int childrenId,bool present)
    {
        _context.Presents.Add(new Present() {Date = date, ChildrenId = childrenId, Presents = present});
        _context.SaveChanges();
    }

    public void Update(int id,DateTime date,int childrenId,bool presents)
    {
        var present = _context.Presents.FirstOrDefault(x => x.Id == id);
        if (present == null) throw new Exception("Null reference");
        present.Date = date;
        present.ChildrenId = childrenId;
        present.Presents = presents;
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var present = _context.Presents.FirstOrDefault(x => x.Id == id);
        if (present == null) throw new Exception("Null reference");
        _context.Presents.Remove(present);
        _context.SaveChanges();
    }

    public Present GetById(int id)
    {
        var present = _context.Presents.FirstOrDefault(x => x.Id == id);
        if (present == null) throw new Exception("Null reference");
        return present;
    }

    public List<Present> GetAll()
    {
        var presents = _context.Presents.Include(x=>x.Children).ToList();
        return presents;
    }
}