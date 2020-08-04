namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DealersC")]
    public partial class DealersC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DealersC()
        {
            DealersD = new HashSet<DealersD>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string R_no { get; set; }

        [Key]
        [Column(Order = 1)]
        public int C_no { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        public virtual DealersR DealersR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DealersD> DealersD { get; set; }
    }
}
