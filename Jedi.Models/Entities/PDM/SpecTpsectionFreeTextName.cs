using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("specTPSectionFreeTextName")]
    public partial class SpecTpsectionFreeTextName
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkTestingProtocolSection", TypeName = "char(40)")]
        public string FkTestingProtocolSection { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
    }
}
