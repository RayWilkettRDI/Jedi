using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonCurrenciesML")]
    public partial class CommonCurrenciesMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(3)]
        public string Abbreviation { get; set; }
        [StringLength(32)]
        public string Name { get; set; }
        [Column("fkCurrency", TypeName = "char(40)")]
        public string FkCurrency { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
