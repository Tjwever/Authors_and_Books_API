using System;
using System.Collections.Generic;

namespace authorsApi.Model
{
    public partial class ArInternalMetadatum
    {
        public string Key { get; set; } = null!;
        public string? Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
