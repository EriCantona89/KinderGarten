using System.ComponentModel.DataAnnotations;

namespace EFLib.Models;

public class Children
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int ParentId { get; set; }
    public Parent Parent { get; set; }
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
}