using Microsoft.EntityFrameworkCore;

namespace StudentPortFolio.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options)
        {

        }

        //Create Table here
        public DbSet<Student> Students { get; set; }
    }
}
