using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS223020_note.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool isBoy { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime CreateDate { get; set; }
        public Blob Avatar { get; set; }
    }
}
