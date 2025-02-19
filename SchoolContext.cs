using System.Data.Entity;

namespace StudentDatabase
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolDB")
        {
            Database.SetInitializer<SchoolContext>(new CreateDatabaseIfNotExists<SchoolContext>());
        }

        public DbSet<Student> Students { get; set; }
    }
} 