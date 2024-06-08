using System.ComponentModel.DataAnnotations;

namespace W8.Models;

public class StudentGroup
{
    [Key]
    public int IdStudentGroup { get; set; }
    
    [MaxLength(100)]
    [Required]
    public string number { get; set; }

    public ICollection<Student> Students { get; set; }
}