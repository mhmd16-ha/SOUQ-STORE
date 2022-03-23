using System;
using System.Collections.Generic;

namespace SOUQ_STORE.Models
{
    public partial class Card
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int? ProductId { get; set; }
        public int? Qty { get; set; }

        public virtual Product? Product { get; set; }
    }
}
