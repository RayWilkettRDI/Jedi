using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Common
{
    [Table("commonExternalIDLookup")]
    public partial class CommonExternalIdlookup
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(250)]
        public string ExternalId { get; set; }
        [Column("fkLookupItem", TypeName = "char(40)")]
        public string FkLookupItem { get; set; }
    }
}
