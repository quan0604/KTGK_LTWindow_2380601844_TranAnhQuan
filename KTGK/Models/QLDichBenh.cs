using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KTGK.Models
{
    public partial class QLDichBenh : DbContext
    {
        public QLDichBenh()
            : base("name=QLDichBenh")
        {
        }

        public virtual DbSet<DiaPhuong> DiaPhuong { get; set; }
        public virtual DbSet<TrangThai> TrangThai { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrangThai>()
                .HasMany(e => e.DiaPhuong)
                .WithRequired(e => e.TrangThai)
                .WillCascadeOnDelete(false);
        }
    }
}
