using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Common
{
    [Table("commonLWFResSetParticipants")]
    public partial class CommonLwfresSetParticipants
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkResolutionSet", TypeName = "char(40)")]
        public string FkResolutionSet { get; set; }
        [Column("fkParticipant", TypeName = "char(40)")]
        public string FkParticipant { get; set; }
    }
}
