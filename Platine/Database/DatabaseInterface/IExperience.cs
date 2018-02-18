using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platine.Database.BusinessObject;

namespace Platine.Database.DatabaseInterface
{
    public interface IExperience
    {
        List<Experience> GetExperienceByUserId(Guid id);

        void AddExperience(Experience experience);

        void UpdateExperience(Experience experience, Guid userId);

        void DeleteExperience(Guid id, Guid userId);

        Experience GetExperienceById(Guid id, Guid userId);
    }
}
