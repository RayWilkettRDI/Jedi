using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmProcessSpecPrintModel")]
    public partial class GsmProcessSpecPrintModel
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(80)]
        public string WorksheetStyle { get; set; }
        [Column("fkCreator", TypeName = "char(40)")]
        public string FkCreator { get; set; }
        [Column(TypeName = "char(4)")]
        public string SpecType { get; set; }
        public int? CheckboxColumnsCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(40)]
        public string Title { get; set; }
        public bool? ShowTotalQuantityRow { get; set; }
    }
}
