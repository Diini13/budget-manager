using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expense_Tracker.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Data
{
    public class AppDbContext: IdentityDbContext<Appuser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public required DbSet<Transaction> Transactions { get; set; }
        public required DbSet<Category> Categories { get; set; }
    }
}