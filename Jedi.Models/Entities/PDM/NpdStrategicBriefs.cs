using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdStrategicBriefs")]
    public partial class NpdStrategicBriefs
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkProjectTemplate", TypeName = "char(40)")]
        public string FkProjectTemplate { get; set; }
        [Column("fkStatus", TypeName = "char(40)")]
        public string FkStatus { get; set; }
        [Column("fkOriginator", TypeName = "char(40)")]
        public string FkOriginator { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OriginationDate { get; set; }
        [Column("fkModifier", TypeName = "char(40)")]
        public string FkModifier { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModificationDate { get; set; }
        [Column(TypeName = "char(7)")]
        public string Num { get; set; }
        public bool? IsMarkedAsDeleted { get; set; }
    }
}
