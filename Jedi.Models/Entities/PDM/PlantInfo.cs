using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class PlantInfo
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [StringLength(128)]
        public string AffiliateName { get; set; }
        [Column("fkAddress", TypeName = "char(40)")]
        public string FkAddress { get; set; }
        [StringLength(50)]
        public string TelephoneNumber { get; set; }
        [StringLength(50)]
        public string FaxNumber { get; set; }
        [StringLength(100)]
        public string BusinessNature { get; set; }
        [StringLength(50)]
        public string Directions { get; set; }
        [StringLength(50)]
        public string DialingInstructions { get; set; }
        [Column("fkSpecBusinessUnit", TypeName = "char(40)")]
        public string FkSpecBusinessUnit { get; set; }
    }
}
