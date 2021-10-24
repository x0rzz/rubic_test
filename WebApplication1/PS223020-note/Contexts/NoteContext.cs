using Microsoft.EntityFrameworkCore;
using PS223020_note.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS223020_note.Contexts
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> option) : base(option)
        {

        }

        public DbSet<Note> Notes { get; set; }
    }
}
