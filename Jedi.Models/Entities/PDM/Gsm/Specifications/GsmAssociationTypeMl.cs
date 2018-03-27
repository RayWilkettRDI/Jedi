using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("gsmAssociationTypeML")]
    public partial class GsmAssociationTypeMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(200)]
        public string Targetname { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(200)]
        public string Hostname { get; set; }
        [Column("fkAssociationType", TypeName = "char(40)")]
        public string FkAssociationType { get; set; }
    }
}
