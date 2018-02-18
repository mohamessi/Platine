using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platine.Database.BusinessObject;

namespace Platine.Database.DatabaseInterface
{
    public interface IEducation
    {
        List<Education> GetEducationsByUserId(Guid id);

        void AddEducation(Education education);

        void UpdateEducation(Education education);

        void DeleteEducation(Guid id);

        Education GetEducationById(Guid id);
    }
}
