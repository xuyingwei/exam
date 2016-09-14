namespace Exam.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Entity : DbContext
    {
        public Entity()
            : base("name=Entity")
        {
        }

        public virtual DbSet<Academy> Academy { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Enroll> Enroll { get; set; }
        public virtual DbSet<Major> Major { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOptional(e => e.Student1)
                .WithRequired(e => e.Student2);
        }
    }
}
