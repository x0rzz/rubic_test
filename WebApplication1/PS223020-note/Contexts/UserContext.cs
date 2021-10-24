using Microsoft.EntityFrameworkCore;
using PS223020_note.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS223020_note.Contexts
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> option) : base(option)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
