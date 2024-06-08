using System.ComponentModel.DataAnnotations;

namespace W8.Models;

public class Student
{
    [Key]
    public int IdStudent { get; set; }
    
    [MaxLength(100)]
    [Required]
    public string firstName { get; set; }
    
    [MaxLength(100)]
    [Required]
    public string lastName { get; set; }
    
    [MaxLength(100)]
    [Required]
    public string IndexNumber { get; set; }
}