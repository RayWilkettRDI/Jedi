using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdProjectML")]
    public partial class NpdProjectMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string Title { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkProject", TypeName = "char(40)")]
        public string FkProject { get; set; }
        [Column("description")]
        [StringLength(3000)]
        public string Description { get; set; }
    }
}
