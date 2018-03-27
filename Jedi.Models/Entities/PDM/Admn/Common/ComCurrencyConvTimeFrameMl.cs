using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Common
{
    [Table("comCurrencyConvTimeFrameML")]
    public partial class ComCurrencyConvTimeFrameMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkCurrencyConversionTimeFrame", TypeName = "char(40)")]
        public string FkCurrencyConversionTimeFrame { get; set; }
        [Column("name")]
        [StringLength(64)]
        public string Name { get; set; }
    }
}
