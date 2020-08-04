namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupDetail")]
    public partial class GroupDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string G_no { get; set; }

        [StringLength(30)]
        public string Group_name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Group_view { get; set; }

        public virtual Group Group { get; set; }
    }
}
