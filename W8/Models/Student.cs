using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    
    public ICollection<StudentGroup> StudentGroups { get; set; }
    
    //zeby miec dostep do klucza obcego
    public int IdStudies { get; set; }

    [ForeignKey(nameof(IdStudies))]
    public Studies Studies { get; set; }
}