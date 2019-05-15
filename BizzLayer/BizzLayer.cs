using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizzLayer
{
    static public class UserFacade
    { 
        public static IQueryable<Users> GetUsers(Users searchCrit, string type)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from el in dc.Users
                      where
                      (String.IsNullOrEmpty(searchCrit.Surname) || el.Surname.StartsWith(searchCrit.Surname))
                      &&
                      (String.IsNullOrEmpty(searchCrit.Name) || el.Name.StartsWith(searchCrit.Name))
                      &&
                      (String.IsNullOrEmpty(type) || el.TypeOfUser.Equals(type))
                      select el;
            return res;
        }

        public static IQueryable<dynamic> GetStudents(Users searchCrit, int number)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from el in dc.Users
                      join ol in dc.Students on el.ID equals ol.UserID
                      where
                      (String.IsNullOrEmpty(searchCrit.Surname) || el.Surname.StartsWith(searchCrit.Surname))
                      &&
                      (String.IsNullOrEmpty(searchCrit.Name) || el.Name.StartsWith(searchCrit.Name))
                      &&
                      (number == 0) || (number == Convert.ToInt32(ol.AlbumNr))
                      select new
                      {
                        el.ID,
                        el.Login,
                        el.Name,
                        el.Surname,
                        el.Password,
                        el.TypeOfUser,
                        ol.UserID,
                        ol.AlbumNr
                      };
            return res;
        }

        public static int GetMaxIndex()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            string[] numbers = dc.Students.ToList().Select(x => x.AlbumNr).ToArray();
            int[] ints = Array.ConvertAll(numbers, int.Parse);
            int max = ints.Max();
            return max;
        }

        public static int GetAlbumNumber(int id)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            string[] words = dc.Students.Where(x => x.UserID == id).Select(x => x.AlbumNr).ToArray();              
            return Convert.ToInt32(words[0]);
        }

        public static Users GetTeacher(int id)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            var res = (from el in dc.Users
                      join ol in dc.Teachers on el.ID equals ol.UserID
                      where
                      (id == Convert.ToInt32(ol.ID))
                      select el).SingleOrDefault();
            return res;
        }

        public static Users[] GetSectionSquad(int id)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            Users[] res =  (from el in dc.Users
                       join ol in dc.Students on el.ID equals ol.UserID
                       join il in dc.Students_Groups on ol.AlbumNr equals il.StudentAlbumNr
                       where
                       (id == Convert.ToInt32(il.GroupID))
                       select el).ToArray();
            return res;
        }

        public static Users InsertUser(Users user)
        {
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                var res = new Users();
                res.ID = -1;
                res.Login = user.Login;
                res.Name = user.Name;
                res.Surname = user.Surname;
                res.Password = user.Password;
                res.TypeOfUser = user.TypeOfUser;
                dc.Users.InsertOnSubmit(res);
                dc.SubmitChanges();
                return res;
            }
        }

        public static void InsertStudent(Users user, int album_nr)
        {
            var student = InsertUser(user);
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                Students std = new Students();
                std.UserID = student.ID;
                std.AlbumNr = (album_nr + 1).ToString();
                dc.Students.InsertOnSubmit(std);
                dc.SubmitChanges();
            }
        }

        public static void InsertTeacher(Users user, string degree)
        {
            var teacher = InsertUser(user);
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                Teachers tch = new Teachers();
                tch.AcademicDegree = degree;
                tch.UserID = teacher.ID;
                tch.ID = -1;
                dc.Teachers.InsertOnSubmit(tch);
                dc.SubmitChanges();
            }
        }

        public static void UpdateUsers(Users user)
        {
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                var res = (from el in dc.Users
                           where el.ID == user.ID
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                res.Login = user.Login;
                res.Name = user.Name;
                res.Surname = user.Surname;
                res.TypeOfUser = user.TypeOfUser;
                dc.SubmitChanges();
            }
        }

        public static Users LogIn(Users searchCrit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            Users usr = dc.Users.Where(x => Equals(x.Password,searchCrit.Password)).Where(x=> Equals(x.Login, searchCrit.Login)).Select(x => x).SingleOrDefault();
            return usr;
        }
    }

    static public class DependencyFacade
    {
        public static IQueryable<dynamic> GetSections(Groups searchCrit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from el in dc.Groups
                      where
                      ((el.ID == searchCrit.ID) || (searchCrit.ID == 0))
                      select new
                      {
                          el.ID,
                          el.GroupSize,
                          el.TopicID,
                          el.SemID
                      };
            return res;
        }

        public static IQueryable<dynamic> GetTopics(Topics searchCrit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from el in dc.Topics
                      join ol in dc.Teachers on el.TeacherID equals ol.ID
                      join il in dc.Users on ol.UserID equals il.ID
                      where
                      ((el.ID == searchCrit.ID) || (searchCrit.ID == 0))
                      &&
                      (el.Title.StartsWith(searchCrit.Title) || string.IsNullOrEmpty(searchCrit.Title))
                      select new
                      {
                          el.ID,
                          el.Title,
                          el.Active,
                          il.Name,
                          il.Surname
                      };
            return res;
        }

        public static IQueryable<dynamic> GetAvailableTopics(Topics searchCrit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from el in dc.Topics
                      join ol in dc.Teachers on el.TeacherID equals ol.ID
                      join il in dc.Users on ol.UserID equals il.ID
                      join ul in dc.Groups on el.ID equals ul.TopicID
                      where
                      ((el.ID == searchCrit.ID) || (searchCrit.ID == 0))
                      &&
                      (el.Title.StartsWith(searchCrit.Title) || string.IsNullOrEmpty(searchCrit.Title))
                      select new
                      {
                          el.ID,
                          el.Title,
                          el.Active,
                          il.Name,
                          il.Surname
                      };
            return res;
        }

        public static Topics GetTopicData(Topics searchCrit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = dc.Topics.Where(x => x.ID == searchCrit.ID).Select(s => s).SingleOrDefault();
            return res;
        }

        public static Groups GetSectionData(int topicID)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = dc.Groups.Where(x => x.TopicID == topicID).Select(s => s).SingleOrDefault();
            return res;
        }

        public static int GetStudentNumber(int groupID)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = dc.Students_Groups.Where(x => x.GroupID == groupID).Select(s => s).Count();
            return res;
        }

        public static Groups GetMySection(int albumnr)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = (from el in dc.Groups
                      join ol in dc.Students_Groups on el.ID equals ol.GroupID
                      where
                      (Convert.ToInt32(ol.StudentAlbumNr) == albumnr)
                      select el).SingleOrDefault();
            return res;
        }

        public static void InsertSection(Groups section)
        {
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                Groups grp = new Groups
                {
                    GroupSize = section.GroupSize,
                    ID = -1,
                    SemID = 1
                };
                dc.Groups.InsertOnSubmit(grp);
                dc.SubmitChanges();
            }
        }

        public static void InsertTopic(Topics topic)
        {
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                Topics tpc = new Topics
                {
                    ID = -1,
                    Title = topic.Title,
                    Description = topic.Description,
                    Active = "opn",
                    TeacherID = topic.TeacherID
                };
                dc.Topics.InsertOnSubmit(tpc);
                dc.SubmitChanges();
            }
        }

        public static void UpdateTopics(Topics topic)
        {
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                var res = (from el in dc.Topics
                           where el.ID == topic.ID
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                res.ID = topic.ID;
                res.Active = topic.Active;

                if(topic.Title != null)
                {
                    res.Title = topic.Title;
                    res.Description = topic.Description;
                    res.TeacherID = topic.TeacherID;
                }
                dc.SubmitChanges();
            }
        }

        public static void UpdateSection(Groups grp)
        {
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                var res = (from el in dc.Groups
                           where el.ID == grp.ID
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                res.ID = grp.ID;
                res.GroupSize = grp.GroupSize;
                res.TopicID = grp.TopicID;
                dc.SubmitChanges();
            }
        }

        public static int SetTopic(int topicID, int sectionID)
        {
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                var res2 = (from ol in dc.Topics
                            where ol.ID == topicID
                            select ol).SingleOrDefault();
                if (res2 != null)
                {
                    var res = (from el in dc.Groups
                               where el.ID == sectionID
                               select el).SingleOrDefault();
                    if (res == null)
                        return 0;
                    res.ID = sectionID;
                    res.TopicID = topicID;
                    dc.SubmitChanges();
                }
                else
                    return 0;

                return 1;
            }
        }

        public static void SetStudentSection(int album, int topicID)
        {
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                Students_Groups stg = new Students_Groups
                {
                    ID = -1,
                    StudentAlbumNr = album.ToString(),
                    GroupID = DependencyFacade.GetSectionData(topicID).ID
                };

                dc.Students_Groups.InsertOnSubmit(stg);
                dc.SubmitChanges();
            }
        }
    }
}
