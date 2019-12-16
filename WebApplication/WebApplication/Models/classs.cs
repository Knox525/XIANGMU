namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("classs")]
    public partial class classs
    {
        public int id { get; set; }
        [Required(ErrorMessage ="请填写班级名称")]
        [StringLength(20,MinimumLength = 2, ErrorMessage = "班级名称 至少包含两个字符")]
        [Display(Name="班级名称")]
        public string Name { get; set; }
        [Display(Name = "班主任")]
        public int? TeacherId { get; set; }
    }
}
