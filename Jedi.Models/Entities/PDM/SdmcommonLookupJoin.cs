using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("SDMCommonLookupJoin")]
    public partial class SdmcommonLookupJoin
    {
        [Column("fkSDMPKID", TypeName = "char(40)")]
        public string FkSdmpkid { get; set; }
        [Column("fkCommonLookupPKID", TypeName = "char(40)")]
        public string FkCommonLookupPkid { get; set; }
    }
}
