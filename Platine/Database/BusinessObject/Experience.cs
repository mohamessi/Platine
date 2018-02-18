using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Platine.Database.BusinessObject
{
    public class Experience
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool IfEnd { get; set; }
        public string Job { get; set; }
        public string Enterprise { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
    }
}