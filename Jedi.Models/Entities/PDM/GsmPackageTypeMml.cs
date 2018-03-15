using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmPackageTypeMML")]
    public partial class GsmPackageTypeMml
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
        [Column("fkPackageType", TypeName = "char(40)")]
        public string FkPackageType { get; set; }
    }
}
