namespace WebApplication.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using WebApplication.Models.Seeds;
    using WebApplication1.Models;

    public partial class lclEntities : DbContext
    {
        public lclEntities()
            : base("name=CourseManagerContext1")
        {
        }

        public virtual DbSet<classs> classs { get; set; }
        public virtual DbSet<CourseManagements> CourseManagements { get; set; }
        public virtual DbSet<SideBars> SideBars { get; set; }
        public virtual DbSet<student> student { get; set; }
        public virtual DbSet<teacher> teacher { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<ActionLink> ActionLink { get;  set; }
     

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<classs>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<SideBars>()
                .Property(e => e.Controller)
                .IsUnicode(false);

            modelBuilder.Entity<SideBars>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<student>()
                .Property(e => e.xuehao)
                .IsFixedLength();

            modelBuilder.Entity<teacher>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<teacher>()
                .Property(e => e.xingbie)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.Name)
                .IsFixedLength();
        }

        internal object classsToList()
        {
            throw new NotImplementedException();
        }

        internal object courseToList()
        {
            throw new NotImplementedException();
        }

        public System.Data.Entity.DbSet<WebApplication.Models.ActionLinks> ActionLinks { get; set; }

        public System.Data.Entity.DbSet<WebApplication.Models.Courses> Courses { get; set; }
    }
}
