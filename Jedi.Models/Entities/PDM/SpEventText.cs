using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("spEventText")]
    public partial class SpEventText
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string Instructions { get; set; }
        [Column("ID")]
        [StringLength(5)]
        public string Id { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("langValue")]
        [StringLength(75)]
        public string LangValue { get; set; }
    }
}
