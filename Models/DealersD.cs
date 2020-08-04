namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DealersD")]
    public partial class DealersD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string R_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_no { get; set; }

        [Key]
        [Column(Order = 2)]
        public int D_no { get; set; }

        public string Info { get; set; }

        [StringLength(30)]
        public string Img { get; set; }

        public virtual DealersC DealersC { get; set; }
    }
}
