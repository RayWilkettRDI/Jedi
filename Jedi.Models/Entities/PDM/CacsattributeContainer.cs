using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("CACSAttributeContainer")]
    public partial class CacsattributeContainer
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkAttribute", TypeName = "char(40)")]
        public string FkAttribute { get; set; }
    }
}
