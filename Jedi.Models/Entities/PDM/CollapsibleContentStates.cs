using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class CollapsibleContentStates
    {
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        [Column("objectType", TypeName = "char(4)")]
        public string ObjectType { get; set; }
        [StringLength(200)]
        public string ContentIdentifier { get; set; }
        [Required]
        [StringLength(50)]
        public string DisplayState { get; set; }
    }
}
