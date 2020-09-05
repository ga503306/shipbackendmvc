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
        [Display(Name ="�b��")]
        public string Username { get; set; }

        [StringLength(100)]
        [Display(Name = "�K�X")]
        public string Password { get; set; }

        //[StringLength(10)]
        //public string Auth { get; set; }

        [StringLength(100)]
        [Display(Name = "�K�X�Q")]
        public string PasswordSalt { get; set; }

        [StringLength(10)]
        public string Auth { set; get; }
        [ForeignKey("Auth")]
        public virtual Group Group_value { set; get; }
    }
}
