namespace TamWarehouse.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            Products = new HashSet<Product>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FName { get; set; }

        [Required]
        [StringLength(50)]
        public string LName { get; set; }

        public int Phone { get; set; }

        public string Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }

        public virtual Staff Staff1 { get; set; }

        public virtual Staff Staff2 { get; set; }
    }
}
