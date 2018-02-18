using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Platine.Database.BusinessObject
{
    public class Skill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid SkillNameId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Level { get; set; }
        public Guid UserId { get; set; }
    }
}