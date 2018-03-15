using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("orobjectassociationmetainfo")]
    public partial class Orobjectassociationmetainfo
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkorobjectpropertymetainfo", TypeName = "char(40)")]
        public string Fkorobjectpropertymetainfo { get; set; }
        [Column("active")]
        public bool Active { get; set; }
        [Required]
        [Column("factoryURL", TypeName = "char(300)")]
        public string FactoryUrl { get; set; }
        [Column("DBFunctionName")]
        [StringLength(500)]
        public string DbfunctionName { get; set; }
    }
}
