using EFLib.Models;

namespace EFLib.Services;


public class ParentService : IParentService
{
    private readonly AppDbContext _context;
    
    public ParentService( )
    {
        _context = new AppDbContextFactory().CreateDbContext();
    }
    
    public void Create(string firstName,string lastName)
    {
        _context.Parents.Add(new Parent() {FirstName = firstName,LastName = lastName });
        _context.SaveChanges();
    }
    
    public void Update(int id, string firstName,string lastName)
    {
        var parent = _context.Parents.FirstOrDefault(x => x.Id == id);
        if (parent == null) throw new Exception("Null reference");
        parent.FirstName = firstName;
        parent.LastName = lastName;
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var parent = _context.Parents.FirstOrDefault(x => x.Id == id);
        if (parent == null) throw new Exception("Null reference");
        _context.Parents.Remove(parent);
        _context.SaveChanges();
    }

    public Parent GetById(int id)
    {
        var parent = _context.Parents.FirstOrDefault(x => x.Id == id);
        if (parent == null) throw new Exception("Null reference");
        return parent;
    }

    public List<Parent> GetAll()
    {
        var parents = _context.Parents.ToList();
        return parents;
    }
    
}

