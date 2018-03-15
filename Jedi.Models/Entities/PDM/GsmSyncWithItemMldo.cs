using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmSyncWithItemMLDO")]
    public partial class GsmSyncWithItemMldo
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(25)]
        public string Exchange { get; set; }
    }
}
