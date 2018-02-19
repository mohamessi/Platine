using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Platine.Database.BusinessObject;
using Platine.Database.DatabaseInterface;
using Platine.Database.Context;
using Platine.Exceptions;

namespace Platine.Database.DatabaseController
{
    public class SkillEntity : ISkill
    {
        public void AddSkill(Skill skill)
        {
            using(var ctx = new PlatineContext())
            {
                ctx.Skills.Add(skill);
                ctx.SaveChanges();
            }
        }

        public void AddSkillName(SkillName skillName)
        {
            using (var ctx = new PlatineContext())
            {
                ctx.SkillNames.Add(skillName);
                ctx.SaveChanges();
            }
        }

        public void DeleteSkill(Guid id)
        {
            throw new NotImplementedException();
        }

        public void DeleteSkillName(Guid id)
        {
            throw new NotImplementedException();
        }

        public void EditSkill(Skill skill)
        {
            throw new NotImplementedException();
        }

        public void EditSkillName(SkillName skillName)
        {
            throw new NotImplementedException();
        }

        public List<Skill> GetSkillBySkillNameId(Guid id)
        {
            using (var ctx = new PlatineContext())
            {
                return ctx.Skills.Where(s => s.SkillNameId.Equals(id)).ToList();
            }
        }

        public List<SkillName> GetSkillNameByUserId(Guid id)
        {
            using (var ctx = new PlatineContext())
            {
                return ctx.SkillNames.Where(s => s.UserId.Equals(id)).ToList();
            }
        }
    }
}