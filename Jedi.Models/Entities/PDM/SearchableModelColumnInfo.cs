using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class SearchableModelColumnInfo
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(64)]
        public string DataField { get; set; }
        [Column("fkSearchableModel", TypeName = "char(40)")]
        public string FkSearchableModel { get; set; }
        [Column("ColumnID")]
        public int? ColumnId { get; set; }
        public int? ColumnIndex { get; set; }
        [StringLength(400)]
        public string DataViewTransformationFactory { get; set; }
        [StringLength(16)]
        public string AggregationDelimiter { get; set; }
        public int? Width { get; set; }
        public bool? IsAggregatable { get; set; }
        [StringLength(128)]
        public string DataFormatter { get; set; }
        public bool? IsRequired { get; set; }
        [Column("ProvideInSelectJS")]
        public bool? ProvideInSelectJs { get; set; }
        [StringLength(128)]
        public string HeaderText { get; set; }
        [StringLength(128)]
        public string DataFieldCaption { get; set; }
        [StringLength(1024)]
        public string EnableHandler { get; set; }
        public bool HideHeader { get; set; }
        public bool? SortingEnabled { get; set; }
        public bool? DisableExport { get; set; }
    }
}
