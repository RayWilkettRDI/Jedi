using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class ObjectNameLookupFactory
    {
        [Key]
        [Column("TypeID")]
        public int TypeId { get; set; }
        [Required]
        [Column(TypeName = "char(500)")]
        public string LookupProviderFactory { get; set; }
    }
}
