using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdPortfolioLayoutItems")]
    public partial class NpdPortfolioLayoutItems
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("configValues")]
        [StringLength(1024)]
        public string ConfigValues { get; set; }
        [Column("title")]
        [StringLength(50)]
        public string Title { get; set; }
        [Column("layoutItemRendererClass")]
        [StringLength(256)]
        public string LayoutItemRendererClass { get; set; }
        [Column("sequenceNumber")]
        public int? SequenceNumber { get; set; }
        [Column("fkLayoutDefinition", TypeName = "char(40)")]
        public string FkLayoutDefinition { get; set; }
    }
}
