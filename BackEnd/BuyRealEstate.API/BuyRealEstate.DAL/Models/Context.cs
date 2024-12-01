using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace BuyRealEstate.DAL.Models
{


    public class BuyRealEstateDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Plot> Plots { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Professional> Professionals { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<LegalStatus> LegalStatuses { get; set; }
        public DbSet<PaymentStatus> PaymentStatus { get; set; }
        public DbSet<DevelopmentStatus> DevelopmentStatuses { get; set; }
        public DbSet<PaymentExecutionMethod> PaymentExecutions { get; set; }
        public DbSet<RelationshipCustomersPlots> CustomerPlots { get; set; }
        public DbSet<RelationshipPaymentsPlots> PlotPayments { get; set; }
        public DbSet<RelationshipPaymentsProjects> PaymentProjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=buyrealestatedb.c1i0c2q8aofb.eu-north-1.rds.amazonaws.com,1433;User Id=BuyRAdmain;Password=liknot_nadlan;");
        }
        


    }

}
