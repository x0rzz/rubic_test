using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Label_percentage
        {
            get => (Percentage * 100).ToString() + "%";
        }
        public float Percentage { get; set; }
        public string Color { get; set; }

    }
}