using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("scrmLegalAggreementML")]
    public partial class ScrmLegalAggreementMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string DateReturned { get; set; }
        [StringLength(256)]
        public string Type { get; set; }
        [Column("fkLegalAgreement", TypeName = "char(40)")]
        public string FkLegalAgreement { get; set; }
        [StringLength(256)]
        public string Location { get; set; }
        [StringLength(256)]
        public string Contact { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
