using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.EFCore.Models.OneToOne
{
    public class Engine
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
