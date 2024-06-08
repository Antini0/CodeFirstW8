using System.ComponentModel.DataAnnotations;

namespace W8.Models;

public class Position
{
    [Key]
    public int IdPosition { get; set; }
    public string name { get; set; }
}