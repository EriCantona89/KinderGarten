using System.ComponentModel.DataAnnotations;

namespace EFLib.Models;

public class Teacher
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}