using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdStageMasterML")]
    public partial class NpdStageMasterMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkStageMaster", TypeName = "char(40)")]
        public string FkStageMaster { get; set; }
        [StringLength(256)]
        public string Title { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
