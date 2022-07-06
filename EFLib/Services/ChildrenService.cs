using EFLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace EFLib.Services;

public class ChildrenService : IChildrenService
{
    private readonly AppDbContext _context;
    public ChildrenService()
    {
        _context = new AppDbContextFactory().CreateDbContext();
    }
    
    public void Create(string firstName,string lastName,int parentId,int teacherId)
    {
        _context.Childrens.Add(new Children() {FirstName = firstName,LastName = lastName, ParentId = parentId,TeacherId = teacherId});
        _context.SaveChanges();
    }

    public void Update(int id, string firstName,string lastName,int parentId,int teacherId)
    {
        var children = _context.Childrens.FirstOrDefault(x => x.Id == id);
        if (children == null) throw new Exception("Null reference");
        children.FirstName = firstName;
        children.LastName = lastName;
        children.ParentId = parentId;
        children.TeacherId = teacherId;
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var children = _context.Childrens.FirstOrDefault(x => x.Id == id);
        if (children == null) throw new Exception("Null reference");
        _context.Childrens.Remove(children);
        _context.SaveChanges();
    }

    public Children GetById(int id)
    {
        var children = _context.Childrens.Include(x=>x.Parent).Include(x=>x.Teacher).FirstOrDefault(x => x.Id == id);
        if (children == null) throw new Exception("Null reference");
        return children;
    }

    public List<Children> GetAll()
    {
        var childrens = _context.Childrens.Include(x=>x.Parent).Include(x=>x.Teacher).ToList();
        return childrens;
    }
}