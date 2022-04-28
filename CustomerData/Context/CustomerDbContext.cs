using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerData.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerData.Context
{
    public class CustomerDbContext: DbContext
    {
        private readonly string _connectionString;

        public CustomerDbContext(): this("Server=DMMBQG3;Database=Customers;User Id=sa;Password=lastgam3counts")
        {

        }

        public CustomerDbContext(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public DbSet<CustomerEntity> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(this._connectionString);
            }
        }
    }
}
