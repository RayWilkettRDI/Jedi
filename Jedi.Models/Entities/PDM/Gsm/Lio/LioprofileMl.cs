using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Lio
{
    [Table("LIOProfileML")]
    public partial class LioprofileMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(250)]
        public string Title { get; set; }
        [Column("fkLIOProfile", TypeName = "char(40)")]
        public string FkLioprofile { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(1024)]
        public string Description { get; set; }
    }
}
