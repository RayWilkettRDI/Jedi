using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdIdeaOrigins")]
    public partial class NpdIdeaOrigins
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(125)]
        public string Name { get; set; }
        [Column("status")]
        public int? Status { get; set; }
    }
}
