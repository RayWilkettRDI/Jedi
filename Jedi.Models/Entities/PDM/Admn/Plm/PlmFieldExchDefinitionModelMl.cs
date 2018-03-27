using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmFieldExchDefinitionModelML")]
    public partial class PlmFieldExchDefinitionModelMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkFieldExchangeDefinitionModel", TypeName = "char(40)")]
        public string FkFieldExchangeDefinitionModel { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("baseName")]
        [StringLength(64)]
        public string BaseName { get; set; }
        [Column("description")]
        [StringLength(256)]
        public string Description { get; set; }
    }
}
