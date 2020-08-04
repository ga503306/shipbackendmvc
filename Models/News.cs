namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        [Key]
        [StringLength(20)]
        public string Newsno { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Info { get; set; }

        public string Context { get; set; }

        public DateTime? Inday { get; set; }

        public string Img { get; set; }

        public int? Priority { get; set; }
    }
}
