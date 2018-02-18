using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Platine.Database.BusinessObject
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public DateTime Birth { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Facebook { get; set; } = "";
        public string Github { get; set; } = "";
        public string Phone { get; set; } = "";
    }
}