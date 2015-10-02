namespace TamWarehouse.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpDate { get; set; }

        public int Location { get; set; }

        [Column(TypeName = "date")]
        public DateTime StockDate { get; set; }

        public int ImportedBy { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
