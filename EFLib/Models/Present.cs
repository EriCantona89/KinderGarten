using System.ComponentModel.DataAnnotations;

namespace EFLib.Models;

public class Present
{
    [Key]
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int ChildrenId { get; set; }
    public Children Children { get; set; }
    public bool Presents { get; set; }
}