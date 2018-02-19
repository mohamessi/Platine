using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Platine.Database.DatabaseInterface;
using Platine.Database.DatabaseController;


namespace Platine.Database
{
    public class DataAccessAction
    {
        public static IUser user = new UserEntity();
        public static IExperience experience = new ExperienceEntity();
        public static IEducation education = new EducationEntity();
        public static ISkill skill = new SkillEntity(); 
    }
}