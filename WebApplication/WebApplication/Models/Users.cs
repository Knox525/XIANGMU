namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "’À∫≈")]
        public string Account { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "”√ªß√˚")]
        public string Name { get; set; }

        [Required]
        [StringLength(256)]
        [Display(Name = "√‹¬Î")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
