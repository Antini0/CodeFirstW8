using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using W8.Models;

namespace W8.Context;

public partial class W7Context : DbContext
{
    public W7Context()
    {
    }

    public W7Context(DbContextOptions<W7Context> options)
        : base(options)
    {
    }
    
    public DbSet<Student> Students { get; set; }
    
    public DbSet<StudentGroup> StudentGroups { get; set; }
    
    public DbSet<Studies> Studies { get; set; }
    public DbSet<Employe> Employes { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<DeansOfficeEmp> DeansOfficeEmps { get; set; }
   
}
