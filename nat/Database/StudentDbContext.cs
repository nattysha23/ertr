using Microsoft.EntityFrameworkCore;
namespace nat.Database
{
    public class StudentDbContext: DbContext
    {
public StudentDbContext(DbContextOptions<StudentDbContext> options): base(options)
        { 
        }  
    }
}
