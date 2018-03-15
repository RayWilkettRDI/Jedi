using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("persistentQueueNumberManager")]
    public partial class PersistentQueueNumberManager
    {
        [Column("currentSequence")]
        public int CurrentSequence { get; set; }
        [Key]
        [StringLength(250)]
        public string Type { get; set; }
        [Column("nextNum")]
        public int? NextNum { get; set; }
    }
}
