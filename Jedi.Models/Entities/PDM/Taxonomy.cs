using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class Taxonomy
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column(TypeName = "char(40)")]
        public string Cat1 { get; set; }
        [Required]
        [Column(TypeName = "char(40)")]
        public string Cat2 { get; set; }
        [Required]
        [Column(TypeName = "char(40)")]
        public string Cat3 { get; set; }
        [Required]
        [Column(TypeName = "char(40)")]
        public string Cat4 { get; set; }
        [Required]
        [Column(TypeName = "char(40)")]
        public string Cat5 { get; set; }
    }
}
