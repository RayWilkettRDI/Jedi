using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("UserSCRMPreference")]
    public partial class UserScrmpreference
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        [Column("ShowArchivedSCRMObjects")]
        public bool? ShowArchivedScrmobjects { get; set; }
        [Column("ShowHiddenSAs")]
        public bool? ShowHiddenSas { get; set; }
    }
}
