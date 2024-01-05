using CleanArc.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Data;

public class CleanArcContext(DbContextOptions<CleanArcContext> options) : DbContext(options)
{

    public virtual DbSet<Course> Course { get; set; }
}
