namespace LibraryManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("admin")]
    public partial class admin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(120)]
        public string AdminEmail { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime updationDate { get; set; }
    }
}
