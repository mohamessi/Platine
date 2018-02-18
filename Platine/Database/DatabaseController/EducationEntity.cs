using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Platine.Database;
using Platine.Database.BusinessObject;
using Platine.Database.DatabaseInterface;
using Platine.Exceptions;
using Platine.Database.Context;

namespace Platine.Database.DatabaseController
{
    public class EducationEntity : IEducation
    {
        public void AddEducation(Education education)
        {
            using (var ctx = new PlatineContext())
            {
                ctx.Educations.Add(education);
                ctx.SaveChanges();
            }
        }

        public void DeleteEducation(Guid id)
        {
            using (var ctx = new PlatineContext())
            {
                var query = ctx.Educations.SingleOrDefault(e => e.Id.Equals(id));
                ctx.Educations.Remove(query);
                ctx.SaveChanges();
            }
        }

        public Education GetEducationById(Guid id)
        {
            using (var ctx = new PlatineContext())
            {
                var query = ctx.Educations.SingleOrDefault(e => e.Id.Equals(id));
                if (query == null)
                    throw new MissingException("Education");
                return query;

            }
        }

        public List<Education> GetEducationsByUserId(Guid id)
        {
            using (var ctx = new PlatineContext())
            {
                //List<Education> l = new List<Education>();
                var query = ctx.Educations.Where(e => e.UserId.Equals(id)).ToList();
                
                return query;
            }
        }

        public void UpdateEducation(Education education)
        {
            using (var ctx = new PlatineContext())
            {
                ctx.Entry(education).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}