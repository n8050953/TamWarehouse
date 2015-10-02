namespace TamWarehouse.DataAccess
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;
	using TamWarehouse.Entity;

	public class TamWarehouseContext : DbContext
	{
		public TamWarehouseContext()
			: base("name=TamWarehouseDB")
		{
		}

		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<Staff> Staffs { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>()
					.Property(e => e.Name)
					.IsUnicode(false);

			modelBuilder.Entity<Product>()
					.Property(e => e.Description)
					.IsUnicode(false);

			modelBuilder.Entity<Product>()
					.Property(e => e.Price)
					.HasPrecision(19, 4);

			modelBuilder.Entity<Staff>()
					.Property(e => e.FName)
					.IsUnicode(false);

			modelBuilder.Entity<Staff>()
					.Property(e => e.LName)
					.IsUnicode(false);

			modelBuilder.Entity<Staff>()
					.Property(e => e.Address)
					.IsUnicode(false);

			modelBuilder.Entity<Staff>()
					.HasMany(e => e.Products)
					.WithRequired(e => e.Staff)
					.HasForeignKey(e => e.ImportedBy)
					.WillCascadeOnDelete(false);

			modelBuilder.Entity<Staff>()
					.HasOptional(e => e.Staff1)
					.WithRequired(e => e.Staff2);
		}
	}
}
