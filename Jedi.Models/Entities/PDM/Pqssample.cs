using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("PQSSample")]
    public partial class Pqssample
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkModifier", TypeName = "char(40)")]
        public string FkModifier { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column("fkCreator", TypeName = "char(40)")]
        public string FkCreator { get; set; }
        [Column("fkPQSSampleType", TypeName = "char(40)")]
        public string FkPqssampleType { get; set; }
        [Column("fkReceivingFacility", TypeName = "char(40)")]
        public string FkReceivingFacility { get; set; }
        [Column("fkTemplate", TypeName = "char(40)")]
        public string FkTemplate { get; set; }
        [Column("fkSourceFacility", TypeName = "char(40)")]
        public string FkSourceFacility { get; set; }
        [Column("LotSampleID")]
        [StringLength(35)]
        public string LotSampleId { get; set; }
        [Column("GTINUPC")]
        [StringLength(14)]
        public string Gtinupc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModificationDate { get; set; }
        [StringLength(1024)]
        public string Notes { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ManufactureDate { get; set; }
        [Column("InternalSampleID")]
        [StringLength(15)]
        public string InternalSampleId { get; set; }
        [Column("fkSpecClassification", TypeName = "char(40)")]
        public string FkSpecClassification { get; set; }
        [Column("fkSpecification", TypeName = "char(40)")]
        public string FkSpecification { get; set; }
        [Column("fkScoringLocation", TypeName = "char(40)")]
        public string FkScoringLocation { get; set; }
        [StringLength(400)]
        public string ReceivingCondition { get; set; }
        [StringLength(15)]
        public string InternalAlias { get; set; }
        [Column("fkQuantityLookup", TypeName = "char(40)")]
        public string FkQuantityLookup { get; set; }
        public double? Temperature { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TestScheduledDate { get; set; }
        [Column("fkTemperatureUOM", TypeName = "char(40)")]
        public string FkTemperatureUom { get; set; }
        [StringLength(20)]
        public string WayBill { get; set; }
        public double? Quantity { get; set; }
        [StringLength(20)]
        public string ReceivingNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UseThroughDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceivedDate { get; set; }
    }
}
