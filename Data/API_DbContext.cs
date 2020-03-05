using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_FinancialManager_Core.Models;

namespace API_FinancialManager_Core.Data
{
    public class API_DbContext : DbContext
    {
        public API_DbContext (DbContextOptions<API_DbContext> options)
            : base(options)
        {
        }

        public DbSet<API_FinancialManager_Core.Models.Conta> FIN001_Conta { get; set; }

        public DbSet<API_FinancialManager_Core.Models.Movimento> MOV001_Movimento { get; set; }

        
    }
}
