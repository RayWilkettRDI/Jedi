using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.TestingProtocol
{
    [Table("TestingProtocolScopeML")]
    public partial class TestingProtocolScopeMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(4)]
        public string ScopeId { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}
