using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Platine.Database.BusinessObject
{
    public class Education
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool IfEnd { get; set; }
        public string Description { get; set; }
        public string Mention { get; set; }
        public string Deegree { get; set; }
        public string Place { get; set; }
        public Guid UserId { get; set; }
    }
}