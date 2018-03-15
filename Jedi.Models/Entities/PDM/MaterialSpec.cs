using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class MaterialSpec
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("lasteditdate", TypeName = "char(10)")]
        public string Lasteditdate { get; set; }
        [Column("fkNutrientMesurementUOM", TypeName = "char(40)")]
        public string FkNutrientMesurementUom { get; set; }
        public bool? IsInternal { get; set; }
        public bool? IsExternal { get; set; }
        public bool? IsReferenced { get; set; }
        public bool? IsRawMaterial { get; set; }
        public int? OutputType { get; set; }
        public bool IsReferencedOnlyBySnapshot { get; set; }
        public bool IsMarkedForDeletion { get; set; }
        [Column("fkMaterialTypeEx", TypeName = "char(40)")]
        public string FkMaterialTypeEx { get; set; }
        [Column("fkFormulaOutputTypeEx", TypeName = "char(40)")]
        public string FkFormulaOutputTypeEx { get; set; }
    }
}
