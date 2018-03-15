using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmPrintModelRows")]
    public partial class GsmPrintModelRows
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkParentPrintModel", TypeName = "char(40)")]
        public string FkParentPrintModel { get; set; }
        public bool? IsHeaderRow { get; set; }
        [StringLength(256)]
        public string RowLabel { get; set; }
        public int? SequenceNumber { get; set; }
    }
}
