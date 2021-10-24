using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS223020_note.Models
{
    public class Blob
    {
        public int Id { get; set; }
        public byte[] Content { get; set; }
        public string Extension { get; set; }
    }
}
