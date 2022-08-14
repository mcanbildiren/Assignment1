using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.EFCore.Models.OneToOne
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int ModelYear { get; set; }
        public decimal Price { get; set; }

        public Engine Engine { get; set; }
        public int EngineId { get; set; }
    }
}
