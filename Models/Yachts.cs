namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Yachts
    {
        [Key]
        [StringLength(15)]
        public string Yachtsno { get; set; }

        [StringLength(15)]
        public string Modal { get; set; }

        [StringLength(10)]
        public string Modal_n { get; set; }

        public string Overview { get; set; }

        public string Layout { get; set; }

        public string Specification { get; set; }

        [StringLength(50)]
        public string Img { get; set; }

        [StringLength(50)]
        public string Files { get; set; }

        public int? Isnew { get; set; }
    }
}
