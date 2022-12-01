using System;
using System.Collections.Generic;

namespace authorsApi.Model
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Location { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
