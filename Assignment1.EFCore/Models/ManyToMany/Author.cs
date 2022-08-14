using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.EFCore.Models.ManyToMany
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public ICollection<Book_Author> Book_Authors { get; set; } = new List<Book_Author>();
    }
}
