using System;
using System.Collections.Generic;
using System.Linq;
using Platine.Database.BusinessObject;
using Platine.Database.DatabaseInterface;
using Platine.Exceptions;
using Platine.Database.Context;


namespace Platine.Database.DatabaseController
{
    public class ExperienceEntity : IExperience
    {
        public void AddExperience(Experience experience)
        {
            using (var ctx = new PlatineContext())
            {
                ctx.Experiences.Add(experience);
                ctx.SaveChanges();
            }
        }

        public void DeleteExperience(Guid id, Guid userId)
        {
            using (var ctx = new PlatineContext())
            {
                var query = ctx.Experiences.SingleOrDefault(e => e.Id.Equals(id));
                if (query == null)
                    throw new MissingException("Experience");
                if (!query.UserId.Equals(userId))
                    throw new NotAllowedException();
                ctx.Experiences.Remove(query);
                ctx.SaveChanges();
            }
        }



        public Experience GetExperienceById(Guid id, Guid userId)
        {
            using (var ctx = new PlatineContext())
            {
                var query = ctx.Experiences.SingleOrDefault(e => e.Id.Equals(id));
                if (query == null)
                    throw new MissingException("experience");
                if (!query.UserId.Equals(userId))
                    throw new NotAllowedException();
                return query;
            }
        }


        public List<Experience> GetExperienceByUserId(Guid id)
        {
            using (var ctx = new PlatineContext())
            {
                var query = ctx.Experiences.Where(e => e.UserId.Equals(id)).ToList();
                return query;
            }
        }

        public void UpdateExperience(Experience experience, Guid userId)
        {
            using (var ctx = new PlatineContext())
            {
                if (!experience.UserId.Equals(userId))
                    throw new NotAllowedException();

                ctx.Entry(experience).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}