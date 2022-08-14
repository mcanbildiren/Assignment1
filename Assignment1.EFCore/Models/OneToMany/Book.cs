using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.EFCore.Models.ManyToMany;

namespace Assignment1.EFCore.Models.OneToMany
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public ICollection<Book_Author> Book_Authors { get; set; } = new List<Book_Author>();
    }
}
