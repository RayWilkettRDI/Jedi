using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("CACSAttributeML")]
    public partial class CacsattributeMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkAttribute", TypeName = "char(40)")]
        public string FkAttribute { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
