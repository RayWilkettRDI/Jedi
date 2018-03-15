using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("cssTransaction")]
    public partial class CssTransaction
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? Status { get; set; }
        public int? Type { get; set; }
        [Column("fkTradeItemPublication", TypeName = "char(40)")]
        public string FkTradeItemPublication { get; set; }
        [StringLength(1000)]
        public string ResultMessage { get; set; }
        [Column("txKey")]
        [StringLength(60)]
        public string TxKey { get; set; }
        [StringLength(50)]
        public string CorrelationId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
    }
}
