using System.ComponentModel.DataAnnotations;

namespace W8.Models;

public class Studies
{
    [Key]
    public int IdStudies { get; set; }
    
    [MaxLength(100)]
    [Required]
    public string name { get; set; }
    
    
    public ICollection<Student> Students { get; set; }
}