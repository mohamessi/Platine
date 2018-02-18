using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Platine.Models;
using Platine.Database.BusinessObject;


namespace Platine.AleaData
{
    public class AleaUser
    {
        delegate int compare(Experience e1, Experience e2);

        private static int Compare(Experience e1, Experience e2)
        {
            if (e1.Start.Millisecond < e2.Start.Millisecond)
                return 1;
            else if (e1.Start.Millisecond > e2.Start.Millisecond)
                return -1;
            else return 0;
        }
        public static UserProfileModel MomoUser()
        {
            
            User momo = new User
            {
                Id = new Guid(),
                Address = "Stains, France",
                Birth = new DateTime(1994, 05, 25),
                Description = "Je suis actuellement en master 2 Science et Technologie du Logiciel à la Sorbonne Université (anciennement Université Pierre et Marie Curie), " +
                "et stagiaire en tant que développeur logiciel chez Sopra Steria.",
                Facebook = "https://www.facebook.com/mohamed.diallo.752",
                FirstName = "Mohamed",
                Github = "https://github.com/mohamessi",
                Image = "https://media.licdn.com/mpr/mpr/shrinknp_400_400/AAIA_wDGAAAAAQAAAAAAAAreAAAAJDhiZTI3MmU0LTYzZGEtNGJiNi1hMWIxLTBlOGZlYTUwYjBiOQ.jpg",
                Login = "momo",
                Mail = "mohameddiallo93md@gmail.com",
                Name = "DIALLO",
                Password = "pass",
                Phone = "06 69 54 68 76"

            };
            List<Experience> experiences = new List<Experience>();
            
            experiences.Add(new Experience
            {
                Start = new DateTime(2017, 09, 07),
                End = new DateTime(2018, 02, 09),
                Description = "Amelioration du moteur de recherche de zenpark",
                Enterprise = "Zenpark",
                IfEnd = true,
                Job = "Developpeur Full Stack",
                UserId = momo.Id
            });
            experiences.Add(new Experience
            {
                Start = new DateTime(2018, 03, 12),
                End = new DateTime(2018, 09, 07),
                Description = "",
                Enterprise = "Sopra Steria",
                IfEnd = true,
                Job = "Developpeur Full Stack",
                UserId = momo.Id
            });
            experiences.Add(new Experience
            {
                Start = new DateTime(2017, 01, 01),
                End = new DateTime(2017, 05, 01),
                Description = "Logiciel de Planification de tache de maintenace d'avion sous la direction de Karim Tekkal",
                Enterprise = "Universite Paris Diderot",
                IfEnd = true,
                Job = "Developpeur Full Stack et Chef de project",
                UserId = momo.Id
            });
            List<Education> educations = new List<Education>();
            educations.Add(new Education
            {
                Deegree = "Licence Informatique",
                Description = "Licence generale",
                End = new DateTime(2016, 05, 01),
                IfEnd = true,
                Mention = "Assez Bien",
                Place = "Universite Paris Diderot",
                Start = new DateTime(2012, 09, 01),
                UserId = momo.Id,
            });
            educations.Add(new Education
            {
                Deegree = "Baccalaureat Economique et Social",
                Description = "",
                End = new DateTime(2012, 05, 01),
                IfEnd = true,
                Mention = "",
                Place = "Lycee Maurice Ravel",
                Start = new DateTime(2012, 05, 01),
                UserId = momo.Id,
            });
            educations.Add(new Education
            {
                Deegree = "Master 1 Informatique",
                Description = "Specialite Langage et Programmation",
                End = new DateTime(2017, 05, 30),
                IfEnd = true,
                Mention = "Assez Bien",
                Place = "Universite Paris Diderot",
                Start = new DateTime(2016, 09, 01),
                UserId = momo.Id,
            });
            educations.Add(new Education
            {
                Deegree = "Master 2 Informatique",
                Description = "Specialite Science et Technologie du Logiciel",
                End = new DateTime(2018, 09, 07),
                IfEnd = true,
                Mention = "Assez Bien",
                Place = "Sorbonne Université (Université Pierre et Marie Curie)",
                Start = new DateTime(2017, 09, 01),
                UserId = momo.Id,
            });
            List<SkillModel> skillModels = new List<SkillModel>();
            Random r = new Random();
            List<Skill> lp = new List<Skill>()
            {
                new Skill{ Name = "Java",Level = r.Next(30,100), Image="info" },
                new Skill{ Name = "C#",Level = r.Next(30,100), Image="info"  },
                new Skill{ Name = "Java EE",Level = r.Next(30,100), Image="info"  },
                new Skill{ Name = "Javascript",Level = r.Next(30,100), Image="info"  },
                new Skill{ Name = ".Net",Level = r.Next(30,100), Image="info"  },
                new Skill{ Name = "Bootstrap",Level = r.Next(30,100), Image="info"  },
            };
            List<Skill> outils = new List<Skill>()
            {
                new Skill{ Name = "Visual Studio",Level = r.Next(30,100), Image="info"  },
                new Skill{ Name = "Eclipse",Level = r.Next(30,100), Image="info"  },
                new Skill{ Name = "Android Studio",Level = r.Next(30,100), Image="info"  },
                new Skill{ Name = "Javascript",Level = r.Next(30,100), Image="info"  },
            };
            List<Skill> methodes = new List<Skill>
            {
                new Skill{ Name = "Scrum" , Level = 50, Image="info"  },
                new Skill{ Name = "Kanban" , Level = 50, Image="info"  },
                new Skill{ Name = "Cycle en V" , Level = 50, Image="info"  },
            };
            List<Skill> langues = new List<Skill>
            {
                new Skill{ Name = "Français" , Level = 100, Image="info"  },
                new Skill{ Name = "Anglais" , Level = 75, Image="info"  },
                new Skill{ Name = "Allemand" , Level = 25, Image="info"  },
                new Skill{ Name = "peul" , Level = 80, Image="info"  },
            };
            skillModels.Add(new SkillModel
            {
                Name = new SkillName { Name = "Langages de Programation & Framework" },
                Skills = lp
            });
            skillModels.Add(new SkillModel
            {
                Name = new SkillName { Name = "Outils" },
                Skills = outils
            });
            skillModels.Add(new SkillModel
            {
                Name = new SkillName { Name = "Methode de Travail" },
                Skills = methodes,
            });
            skillModels.Add(new SkillModel
            {
                Name = new SkillName { Name = "Langues" },
                Skills = langues
            });

            compare a = new compare(Compare);
            return new UserProfileModel
            {
                User = momo,
                Experiences = experiences.OrderByDescending( e => e.Start).ToList(),
                Educations = educations.OrderByDescending(e => e.Start).ToList(),
                SkillModel = skillModels
            };

        }

    }
}