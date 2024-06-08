using System.ComponentModel.DataAnnotations;

namespace W8.Models;

public class Employe
{
    [Key]
    public int IdEmploye { get; set; }
    
    [MaxLength(100)]
    [Required]
    public string firstName { get; set; }
    
    [MaxLength(100)]
    [Required]
    public string lastName { get; set; }
}

public class Teacher : Employe
{
    public int Salary { get; set; }
}

public class DeansOfficeEmp : Employe
{
    public int Position { get; set; }
}