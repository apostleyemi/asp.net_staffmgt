using Microsoft.EntityFrameworkCore;
using  ems.Models;

namespace ems.Models
{
  public class  EmsContext:DbContext
  {
      public EmsContext(DbContextOptions<EmsContext> options): base(options)
      {

      }
      public DbSet<Employee>Employees{get; set;}
  }


}