using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.Specs
{
    /// <summary>
    /// Abstract Base Class for Agile PLM for Process Entities
    /// </summary>
    public abstract class BaseSpec
    {
        // Summary Information Properties
        [Column("SpecID")]
        public string SpecID { get; set; }
        [Column("SpecNum")]
        public string SpecNum { get; set; }
        [Column("IssueNum")]
        public string IssueNum { get; set; }
        [Column("ShortName")]
        public string ShortName { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("status")]
        public string Status { get; set; }
        [Column("Category")]
        public string Category { get; set; }
        [Column("SubCategory")]
        public string SubCategory { get; set; }
        [Column("Group")]
        public string Group { get; set; }
        [Column("ReasonForChange")]
        public string ReasonForChange { get; set; }
        public IEnumerable<CrossReference> CrossReferences { get; set; }
        //public IEnumerable<string> Segments { get; set; }
        //public IEnumerable<string> BusinessUnits { get; set; }
    }
}
