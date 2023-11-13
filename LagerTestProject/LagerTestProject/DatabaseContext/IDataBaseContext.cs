using LagerTestProject.Entites;
using Microsoft.EntityFrameworkCore;

namespace LagerTestProject.DatabaseContext
{
    public interface IDataBaseContext
    {
        public DbSet<CustomerEntity> Customeres { get; set; }
        public DbSet< AddressEntity> Addresses { get; set; }
        public DbSet< InvoicesEntity> Invoices { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<StoreEntity> Store { get; set; }
        public DbSet<UnitsEntity> Units { get; set; }

        Task<int> SaveChangesAsync();
    }
}
