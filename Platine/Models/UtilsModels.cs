using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Platine.Database.BusinessObject;

namespace Platine.Models
{
   

    public class UserProfileModel
    {
        public User User { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Education> Educations { get; set; }
        public List<SkillModel> SkillModel { get; set; }
        public List<ProjectModel> Projects { get; set; }
    }

    public class SkillModel
    {
        public SkillName Name { get; set; }
        public List<Skill> Skills { get; set; }
    }

    public class ProjectModel
    {
        public Project Project { get; set; }
        public List<ProjectDetail> ProjectImgs { get; set; }
    }


    public class LoginModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class ForgotPasswordModel
    {
        public string Mail { get; set; }
    }

    public class NewPasswordModel
    {
        public string Password { get; set; }
    }
}