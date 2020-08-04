namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TableDetail")]
    public partial class TableDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int T_no { get; set; }

        [Key]
        [Column(Order = 1)]
        public int Td_no { get; set; }

        public int seq { get; set; }

        [StringLength(15)]
        public string Td_name { get; set; }

        public string Url { get; set; }

        public virtual Table Table { get; set; }
    }
}
