using Microsoft.EntityFrameworkCore;
using StudentManagementAPI.Entities;

namespace StudentManagementAPI.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
        : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }

}