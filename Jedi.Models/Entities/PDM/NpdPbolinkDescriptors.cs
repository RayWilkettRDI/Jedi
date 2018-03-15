using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdPBOLinkDescriptors")]
    public partial class NpdPbolinkDescriptors
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("PBOTypeAndAppTranslationURL")]
        [StringLength(200)]
        public string PbotypeAndAppTranslationUrl { get; set; }
        [Column("PBOTypeCaptionTranslationURL")]
        [StringLength(200)]
        public string PbotypeCaptionTranslationUrl { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public bool? Active { get; set; }
        [Column("CaptionBuilderURL")]
        [StringLength(300)]
        public string CaptionBuilderUrl { get; set; }
        [Column("PunchoutBuilderURL")]
        [StringLength(300)]
        public string PunchoutBuilderUrl { get; set; }
        [Column("EQTSelectionViewName")]
        [StringLength(50)]
        public string EqtselectionViewName { get; set; }
        [StringLength(100)]
        public string FeatureSets { get; set; }
        [Column("InfoRetrieverURL")]
        [StringLength(300)]
        public string InfoRetrieverUrl { get; set; }
    }
}
