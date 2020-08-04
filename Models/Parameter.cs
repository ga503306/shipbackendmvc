namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Parameter")]
    public partial class Parameter
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Table_name { get; set; }

        [StringLength(30)]
        public string Key_string { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Value { get; set; }

        [StringLength(30)]
        public string Value_string { get; set; }

        [StringLength(60)]
        public string Url { get; set; }
    }
}
