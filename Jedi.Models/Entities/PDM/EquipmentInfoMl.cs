using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("EquipmentInfoML")]
    public partial class EquipmentInfoMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkEquipmentSpec", TypeName = "char(40)")]
        public string FkEquipmentSpec { get; set; }
        [StringLength(512)]
        public string Description { get; set; }
        [StringLength(100)]
        public string ModelName { get; set; }
    }
}
