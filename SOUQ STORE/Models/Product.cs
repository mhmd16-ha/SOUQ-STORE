using System;
using System.Collections.Generic;

namespace SOUQ_STORE.Models
{
    public partial class Product
    {
        public Product()
        {
            Cards = new HashSet<Card>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? CatId { get; set; }
        public string? Photo { get; set; }

        public virtual Category? Cat { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
    }
}
