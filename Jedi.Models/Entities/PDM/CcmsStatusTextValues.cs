using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("ccmsStatusTextValues")]
    public partial class CcmsStatusTextValues
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langValue")]
        [StringLength(50)]
        public string LangValue { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
