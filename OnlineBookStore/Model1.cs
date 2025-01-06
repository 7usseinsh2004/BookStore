using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OnlineBookStore
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C_order> C_order { get; set; }
        public virtual DbSet<book> books { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<category_name> category_name { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<book>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<book>()
                .Property(e => e.authorName)
                .IsUnicode(false);

            modelBuilder.Entity<book>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<book>()
                .HasMany(e => e.C_order)
                .WithMany(e => e.books)
                .Map(m => m.ToTable("order_books").MapLeftKey("bookId").MapRightKey("orderId"));

            modelBuilder.Entity<category>()
                .HasMany(e => e.category_name)
                .WithRequired(e => e.category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<category_name>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.fName)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.lName)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.eMail)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.pass)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.zipCode)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.street)
                .IsUnicode(false);
        }
    }
}
