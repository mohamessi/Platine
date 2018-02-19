using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platine.Database.BusinessObject;

namespace Platine.Database.DatabaseInterface
{
    public interface ISkill
    {
        List<Skill> GetSkillBySkillNameId(Guid id);

        List<SkillName> GetSkillNameByUserId(Guid id);

        void AddSkillName(SkillName skillName);

        void AddSkill(Skill skill);

        void DeleteSkillName(Guid id);

        void DeleteSkill(Guid id);

        void EditSkillName(SkillName skillName);

        void EditSkill(Skill skill);
    }
}
