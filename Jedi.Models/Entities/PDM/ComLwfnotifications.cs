using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("comLWFNotifications")]
    public partial class ComLwfnotifications
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? IsShared { get; set; }
        [Column("fkFunctionalUnit", TypeName = "char(40)")]
        public string FkFunctionalUnit { get; set; }
        public int? Usage { get; set; }
        [Column("AmberSLA")]
        public int? AmberSla { get; set; }
        [Column("RedSLA")]
        public int? RedSla { get; set; }
        public bool? IsOptional { get; set; }
        public int? Sequence { get; set; }
        [Column("ESignatureEnabled")]
        public bool? EsignatureEnabled { get; set; }
        public int? NumRequired { get; set; }
        public bool? IsCommentsRequired { get; set; }
    }
}
