using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("NPDIdeaML")]
    public partial class NpdideaMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkIdea", TypeName = "char(40)")]
        public string FkIdea { get; set; }
        [StringLength(256)]
        public string Title { get; set; }
        [Column("description")]
        [StringLength(1000)]
        public string Description { get; set; }
    }
}
