namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [StringLength(30)]
        [Display(Name ="±b¸¹")]
        public string Username { get; set; }

        [StringLength(30)]
        [Display(Name = "±K½X")]
        public string Password { get; set; }

        [StringLength(10)]
        public string Auth { get; set; }
    }
}
