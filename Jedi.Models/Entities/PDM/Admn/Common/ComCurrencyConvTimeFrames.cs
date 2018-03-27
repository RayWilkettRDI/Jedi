using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Common
{
    [Table("comCurrencyConvTimeFrames")]
    public partial class ComCurrencyConvTimeFrames
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("startDate", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("endDate", TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column("isActive")]
        public bool? IsActive { get; set; }
    }
}
