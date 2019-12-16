namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("teacher")]
    public partial class teacher
    {
        public int id { get; set; }

        [StringLength(10)]
        public string Name { get; set; }

        [StringLength(10)]
        public string xingbie { get; set; }
    }
}
