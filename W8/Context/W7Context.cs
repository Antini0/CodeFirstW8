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
   
}
