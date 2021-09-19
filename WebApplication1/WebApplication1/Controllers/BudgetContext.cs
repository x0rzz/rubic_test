using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class BudgetContext : DbContext
    {
        public BudgetContext(DbContextOptions<BudgetContext> options)
            :base(options)
        {

        }

        public DbSet<Budget> Budgets { get; set; }
    }
}
