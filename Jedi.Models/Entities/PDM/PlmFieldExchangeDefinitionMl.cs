using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("plmFieldExchangeDefinitionML")]
    public partial class PlmFieldExchangeDefinitionMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(266)]
        public string Name { get; set; }
        [StringLength(256)]
        public string Description { get; set; }
        [Column("fkFieldExchangeDefinition", TypeName = "char(40)")]
        public string FkFieldExchangeDefinition { get; set; }
    }
}
