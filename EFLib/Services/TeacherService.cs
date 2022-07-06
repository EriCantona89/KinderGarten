using EFLib.Models;

namespace EFLib.Services;

public class TeacherService : ITeacherService
{
    private readonly AppDbContext _context;
    public TeacherService()
    {
        _context = new AppDbContextFactory().CreateDbContext();
    }
    public void Create(string firstName,string lastName)
    {
        _context.Teachers.Add(new Teacher() {FirstName = firstName,LastName = lastName });
        _context.SaveChanges();
    }

    public void Update(int id, string firstName,string lastName)
    {
        var teacher = _context.Teachers.FirstOrDefault(x => x.Id == id);
        if (teacher == null) throw new Exception("Null reference");
        teacher.FirstName = firstName;
        teacher.LastName = lastName;
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var teacher = _context.Teachers.FirstOrDefault(x => x.Id == id);
        if (teacher == null) throw new Exception("Null reference");
        _context.Teachers.Remove(teacher);
        _context.SaveChanges();
    }

    public Teacher GetById(int id)
    {
        var teacher = _context.Teachers.FirstOrDefault(x => x.Id == id);
        if (teacher == null) throw new Exception("Null reference");
        return teacher;
    }

    public List<Teacher> GetAll()
    {
        var teachers = _context.Teachers.ToList();
        return teachers;
    }
}