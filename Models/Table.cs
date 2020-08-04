namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table()
        {
            TableDetail = new HashSet<TableDetail>();
        }

        [Key]
        public int T_no { get; set; }

        [StringLength(15)]
        public string T_id { get; set; }

        [StringLength(15)]
        public string T_name { get; set; }

        [StringLength(30)]
        public string T_icon { get; set; }

        public int? seq { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TableDetail> TableDetail { get; set; }
    }
}
