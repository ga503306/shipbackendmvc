namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model1")
        {
        }

        public virtual DbSet<DealersC> DealersC { get; set; }
        public virtual DbSet<DealersD> DealersD { get; set; }
        public virtual DbSet<DealersR> DealersR { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<GroupDetail> GroupDetail { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Parameter> Parameter { get; set; }
        public virtual DbSet<Table> Table { get; set; }
        public virtual DbSet<TableDetail> TableDetail { get; set; }
        public virtual DbSet<Yachts> Yachts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DealersC>()
                .HasMany(e => e.DealersD)
                .WithRequired(e => e.DealersC)
                .HasForeignKey(e => new { e.R_no, e.C_no })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DealersR>()
                .HasMany(e => e.DealersC)
                .WithRequired(e => e.DealersR)
                .WillCascadeOnDelete(false);
        }
    }
}
