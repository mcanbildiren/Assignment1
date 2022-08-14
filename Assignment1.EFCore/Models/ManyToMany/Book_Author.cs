using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.EFCore.Models.OneToMany;

namespace Assignment1.EFCore.Models.ManyToMany
{
    public class Book_Author
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
