using MYARCH.CORE;
using System.Data.Entity;

namespace MYARCH.DATA.Context
{
    public partial class MyArchContext : DbContext
    {
        private readonly MyArchContext _context;

        public MyArchContext() : base("name=My ArchEntites")
        {
            //veritabanonda ilişkiler zaten tanımlı bir daha tanımlamana gereNk yok dedik şu an
            Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Category> Category { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User", "dbo");
            modelBuilder.Entity<Post>().ToTable("Post", "dbo");
            modelBuilder.Entity<Category>().ToTable("Category", "dbo");
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
