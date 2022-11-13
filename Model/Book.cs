using System;
using System.Collections.Generic;

namespace authorsApi.Model
{
    public partial class Book
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Genre { get; set; }
        public int? Pages { get; set; }
        public long? AuthorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Author? Author { get; set; }
    }
}
