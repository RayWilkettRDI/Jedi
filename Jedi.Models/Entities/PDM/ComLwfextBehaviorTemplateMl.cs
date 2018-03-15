using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("comLWFExtBehaviorTemplateML")]
    public partial class ComLwfextBehaviorTemplateMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkLWFExtendedBehaviorTemplate", TypeName = "char(40)")]
        public string FkLwfextendedBehaviorTemplate { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
    }
}
