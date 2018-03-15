using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class TableRenameLookup
    {
        [Key]
        [Column("oldName")]
        [StringLength(200)]
        public string OldName { get; set; }
        [Required]
        [Column("newName")]
        [StringLength(30)]
        public string NewName { get; set; }
    }
}
