using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class ComponentFunction
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("CFText")]
        [StringLength(50)]
        public string Cftext { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("sequence")]
        public int Sequence { get; set; }
        [Column("status")]
        public int? Status { get; set; }
    }
}
