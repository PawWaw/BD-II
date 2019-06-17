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
            BDIIDataContext dc = new BDIIDataContext();
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
            BDIIDataContext dc = new BDIIDataContext();
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
                        el.Hash,
                        el.TypeOfUser,
                        ol.UserID,
                        ol.AlbumNr
                      };
            return res;
        }

        public static Users GetSingleStudent(int number)
        {
            BDIIDataContext dc = new BDIIDataContext();
            var res = (from el in dc.Users
                       join ol in dc.Students on el.ID equals ol.UserID
                       where ol.AlbumNr == number.ToString()
                       select el).SingleOrDefault();
            return res;
        }

        public static int GetMaxIndex()
        {
            BDIIDataContext dc = new BDIIDataContext();
            string[] numbers = dc.Students.ToList().Select(x => x.AlbumNr).ToArray();
            int[] ints = Array.ConvertAll(numbers, int.Parse);
            if (ints.Length != 0)
            {
                int max = ints.Max();
                return max;
            }
            else
                return 262000;
        }

        public static int GetAlbumNumber(int id)
        {
            BDIIDataContext dc = new BDIIDataContext();

            string[] words = dc.Students.Where(x => x.UserID == id).Select(x => x.AlbumNr).ToArray();              
            return Convert.ToInt32(words[0]);
        }

        public static Users GetTeacher(int id)
        {
            BDIIDataContext dc = new BDIIDataContext();

            var res = (from el in dc.Users
                      join ol in dc.Teachers on el.ID equals ol.UserID
                      where
                      (id == Convert.ToInt32(ol.ID))
                      select el).SingleOrDefault();
            return res;
        }

        public static Teachers GetTeacherFromUser(Users usr)
        {
            BDIIDataContext dc = new BDIIDataContext();

            var res = (from el in dc.Users
                       join ol in dc.Teachers on el.ID equals ol.UserID
                       where
                       (usr.ID == Convert.ToInt32(el.ID))
                       select ol).SingleOrDefault();
            return res;
        }

        public static Users[] GetSectionSquad(int id)
        {
            BDIIDataContext dc = new BDIIDataContext();

            Users[] res =  (from el in dc.Users
                       join ol in dc.Students on el.ID equals ol.UserID
                       join il in dc.Students_Groups on ol.AlbumNr equals il.StudentAlbumNr
                       where
                       (id == Convert.ToInt32(il.GroupID) && il.Active == true)
                       select el).ToArray();
            return res;
        }

        public static string GetName(int id)
        {
            BDIIDataContext dc = new BDIIDataContext();

            Users res = (from el in dc.Users
                           join ol in dc.Teachers on el.ID equals ol.UserID
                           where
                           (id == Convert.ToInt32(ol.ID))
                           select el).SingleOrDefault();
            return res.Name + " " + res.Surname;
        }

        public static bool GetStudentSem(Users user, int semID)
        {
            BDIIDataContext dc = new BDIIDataContext();

            var res = (from el in dc.Users
                       join ol in dc.Students on el.ID equals ol.UserID
                       where (user.ID == ol.UserID)
                       select ol).SingleOrDefault();
            if(res != null)
            {
                var res2 = (from il in dc.Sem_Student
                            where 
                            (res.AlbumNr == il.StudentAlbumNr && il.SemID == semID)
                            select il).SingleOrDefault();
                if (res2 != null)
                    return true;
            }
            return false;
        }

        public static int GetGroupStudentID(int userID)
        {
            BDIIDataContext dc = new BDIIDataContext();

            var res = (from el in dc.Students_Groups
                       join ol in dc.Students on el.StudentAlbumNr equals ol.AlbumNr
                       where (userID == ol.UserID)
                       select el).SingleOrDefault();
            if (res != null)
                return res.ID;
            else
                return 0;
        }

        public static Users InsertUser(Users user)
        {
            using (BDIIDataContext dc = new BDIIDataContext())
            {
                var res = new Users();
                res.ID = -1;
                res.Login = user.Login;
                res.Name = user.Name;
                res.Surname = user.Surname;
                res.Hash = user.Hash;
                res.Salt = user.Salt;
                res.TypeOfUser = user.TypeOfUser;
                dc.Users.InsertOnSubmit(res);
                dc.SubmitChanges();
                return res;
            }
        }

        public static void InsertStudent(Users user, int album_nr, int semID)
        {
            var student = InsertUser(user);
            Students std = new Students();
            Sem_Student sms = new Sem_Student();
            using (BDIIDataContext dc = new BDIIDataContext())
            {
                std.UserID = student.ID;
                std.AlbumNr = (album_nr + 1).ToString();
                dc.Students.InsertOnSubmit(std);
                dc.SubmitChanges();
            }

            using (BDIIDataContext dc = new BDIIDataContext())
            {
                sms.StudentAlbumNr = std.AlbumNr;
                sms.SemID = semID;
                dc.Sem_Student.InsertOnSubmit(sms);
                dc.SubmitChanges();
            }
        }

        public static void InsertTeacher(Users user, string degree)
        {
            var teacher = InsertUser(user);
            using (BDIIDataContext dc = new BDIIDataContext())
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
            using (BDIIDataContext dc = new BDIIDataContext())
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
                res.Hash = user.Hash;
                res.Salt = user.Salt;
                dc.SubmitChanges();
            }
        }

        public static void UpdateMark(int userID, double mark)
        {
            using (BDIIDataContext dc = new BDIIDataContext())
            {
                Students res = (from el in dc.Users
                           join ol in dc.Students on el.ID equals ol.UserID
                          where ol.UserID == userID
                           select ol).SingleOrDefault();

                Students_Groups res2 = (from il in dc.Students_Groups
                                        join ul in dc.Students on il.StudentAlbumNr equals ul.AlbumNr
                                        where il.StudentAlbumNr == res.AlbumNr
                                        select il).SingleOrDefault();

                res2.Mark = mark;
                dc.SubmitChanges();
            }
        }

        public static void UpdateGroupStudent(int number, bool state) 
        {
            using (BDIIDataContext dc = new BDIIDataContext())
            {
                Students_Groups res = (from el in dc.Students_Groups
                                      where el.StudentAlbumNr == number.ToString()
                                      select el).SingleOrDefault();

                res.Active = state;
                dc.SubmitChanges();
            }
        }

        public static Users LogIn(Users searchCrit)
        {
            BDIIDataContext dc = new BDIIDataContext();
            Users usr = dc.Users.Where(x => Equals(x.Hash,searchCrit.Hash)).Where(x=> Equals(x.Login, searchCrit.Login)).Select(x => x).SingleOrDefault();
            return usr;
        }

        public static String GetSalt(Users searchCrit)
        {
            BDIIDataContext dc = new BDIIDataContext();
            String salt = dc.Users.Where(x => x.Login == searchCrit.Login).Select(x => x.Salt).SingleOrDefault();
            return salt != null ? salt : null;
        }
    }

    static public class DependencyFacade
    {
        public static IQueryable<dynamic> GetSections(Sections searchCrit, string title)
        {
            BDIIDataContext dc = new BDIIDataContext();
            var res = from el in dc.Sections 
                      join ol in dc.Topics on el.TopicID equals ol.ID into ps
                      from ol in ps.DefaultIfEmpty()
                      where
                      ((el.ID == searchCrit.ID) || (searchCrit.ID == 0) &&
                       (ol.Title.StartsWith(title) || string.IsNullOrEmpty(title)))
                      select new
                      {
                          el.ID,
                          el.GroupSize,
                          el.Status,
                          el.SemID,
                          el.TopicID,
                          ol.Title
                      };
            return res;
        }

        public static Sections GetSection(Sections searchCrit)
        {
            BDIIDataContext dc = new BDIIDataContext();
            var res = (from el in dc.Sections
                       where
                      ((el.ID == searchCrit.ID) || (searchCrit.ID == 0))
                      select el).SingleOrDefault();
            return res;
        }

        public static IQueryable<dynamic> GetTopics(Topics searchCrit)
        {
            BDIIDataContext dc = new BDIIDataContext();
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
                          el.Status,
                          il.Name,
                          il.Surname
                      };
            return res;
        }

        public static Topics[] GetArrayTopics(int teacherID)
        {
            BDIIDataContext dc = new BDIIDataContext();
            Topics[] res = (from el in dc.Topics
                           where el.TeacherID == teacherID
                           select el).ToArray();

            return res;
        }

        public static Topics GetTopicData(Topics searchCrit)
        {
            BDIIDataContext dc = new BDIIDataContext();
            var res = dc.Topics.Where(x => x.ID == searchCrit.ID).Select(s => s).SingleOrDefault();
            return res;
        }

        public static Sections GetSectionData(int topicID)
        {
            BDIIDataContext dc = new BDIIDataContext();
            var res = dc.Sections.Where(x => x.TopicID == topicID).Select(s => s).SingleOrDefault();
            return res;
        }

        public static int GetStudentNumber(int groupID)
        {
            BDIIDataContext dc = new BDIIDataContext();
            var res = dc.Students_Groups.Where(x => x.GroupID == groupID).Where(y => y.Active == true).Select(s => s).Count();
            return res;
        }

        public static Sections GetMySection(int albumnr)
        {
            BDIIDataContext dc = new BDIIDataContext();
            var res = (from el in dc.Sections
                       join ol in dc.Students_Groups on el.ID equals ol.GroupID
                      where
                      (Convert.ToInt32(ol.StudentAlbumNr) == albumnr)
                      select el).SingleOrDefault();
            return res;
        }

        public static int GetMaxSecID()
        {
            using (BDIIDataContext dc = new BDIIDataContext())
            {
                if (dc.Sections.Select(x => x.ID).Count() == 0)
                    return 0;
                else
                    return dc.Sections.Select(x => x.ID).Max();
            }
        }

        public static dynamic GetSems()
        {
            using (BDIIDataContext dc = new BDIIDataContext())
            {
                var res = dc.Sems.Select(x=>x).ToArray();
                return res;
            }
        }

        public static Presence[] GetPresence()
        {
            using (BDIIDataContext dc = new BDIIDataContext())
            {
                Presence[] res = (from el in dc.Presence
                                  select el).ToArray();
                return res;
            }
        }

        public static void InsertSection(Sections section)
        {
            using (BDIIDataContext dc = new BDIIDataContext())
            {
                Sections grp = new Sections
                {
                    GroupSize = section.GroupSize,
                    ID = -1,
                    SemID = 1,
                    Status = "opn"
                };
                dc.Sections.InsertOnSubmit(grp);
                dc.SubmitChanges();
            }
        }

        public static void InsertTopic(Topics topic)
        {
            using (BDIIDataContext dc = new BDIIDataContext())
            {
                Topics tpc = new Topics
                {
                    ID = -1,
                    Title = topic.Title,
                    Description = topic.Description,
                    Status = "opn",
                    TeacherID = topic.TeacherID
                };
                dc.Topics.InsertOnSubmit(tpc);
                dc.SubmitChanges();
            }
        }

        public static void InsertPresenceDate(int sectionID)
        {
            var datetime = DateTime.Now;
            var date = datetime.Date;
            Users[] users = UserFacade.GetSectionSquad(sectionID);
            for(int i = 0; i < users.Length; i++)
            {
                using (BDIIDataContext dc = new BDIIDataContext())
                {
                    Presence prs = new Presence();
                    prs.Present = false;
                    prs.Group_StudentID = UserFacade.GetGroupStudentID(users[i].ID);
                    prs.ID = -1;
                    prs.Date = date;

                    dc.Presence.InsertOnSubmit(prs);
                    dc.SubmitChanges();
                }
            }
        }

        public static void InsertFile(byte[] file, int ID, string comment)
        {
            var datetime = DateTime.Now;
            var date = datetime.Date;

            using (BDIIDataContext dc = new BDIIDataContext())
            {
                Files fls = new Files();
                fls.SectionID = ID;
                fls.File = file;
                fls.Date = date;
                fls.Details = comment;
                dc.Files.InsertOnSubmit(fls);
                dc.SubmitChanges();
            }
        }

        public static void UpdateTopics(Topics topic)
        {
            using (BDIIDataContext dc = new BDIIDataContext())
            {
                var res = (from el in dc.Topics
                           where el.ID == topic.ID
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                res.ID = topic.ID;
                res.Status = topic.Status;

                if(topic.Title != null)
                {
                    res.Title = topic.Title;
                    res.Description = topic.Description;
                    res.TeacherID = topic.TeacherID;
                }
                dc.SubmitChanges();
            }
        }

        public static void UpdateSection(Sections grp)
        {
            using (BDIIDataContext dc = new BDIIDataContext())
            {
                var res = (from el in dc.Sections
                           where el.ID == grp.ID
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                res.ID = grp.ID;
                res.GroupSize = grp.GroupSize;
                res.TopicID = grp.TopicID;
                res.Status = grp.Status;
                dc.SubmitChanges();
            }
        }

        public static void UpdatePresences(DateTime column, int ID, string value)
        {
            using (BDIIDataContext dc = new BDIIDataContext())
            {
                var res = (from el in dc.Presence
                           where ((el.Group_StudentID == ID) && (el.Date == column))
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                if (value.Equals("0"))
                    res.Present = false;
                else
                    res.Present = true;
                dc.SubmitChanges();
            }
        }

        public static int SetTopic(int topicID, int sectionID)
        {
            using (BDIIDataContext dc = new BDIIDataContext())
            {
                var res2 = (from ol in dc.Topics
                            where ol.ID == topicID
                            select ol).SingleOrDefault();
                if (res2 != null)
                {
                    var res = (from el in dc.Sections
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

        public static void SetStudentSection(int album, Sections sec)
        {
            int nr = 0;
            int oldnr = 0;
            using (BDIIDataContext dc = new BDIIDataContext())
            {
                var res = dc.Students_Groups.Where(x => Convert.ToInt32(x.StudentAlbumNr) == album).Select(x => x).SingleOrDefault();

                if(res == null)
                {
                    Students_Groups stg = new Students_Groups
                    {
                        ID = -1,
                        Active = true,
                        StudentAlbumNr = album.ToString(),
                        GroupID = DependencyFacade.GetSection(sec).ID
                    };

                    dc.Students_Groups.InsertOnSubmit(stg);
                    dc.SubmitChanges();
                }
                else
                {
                    res.ID = res.ID;
                    res.StudentAlbumNr = res.StudentAlbumNr;
                    oldnr = res.GroupID;
                    if (sec.ID != 0)
                        res.GroupID = DependencyFacade.GetSection(sec).ID;
                    else
                        res.Active = false;
                    nr = res.GroupID;
                    dc.SubmitChanges();
                }
            }

            Sections oldgrp = new Sections();
            Sections newgrp = new Sections();
            Topics topic = new Topics();
            oldgrp.ID = oldnr;
            newgrp.ID = nr;
            oldgrp = (Sections)DependencyFacade.GetSection(oldgrp);
            newgrp = (Sections)DependencyFacade.GetSection(newgrp);

            if(newgrp.GroupSize == DependencyFacade.GetStudentNumber(newgrp.ID))
            {
                newgrp.Status = "Close";
                DependencyFacade.UpdateSection(newgrp);
            }
            if(oldgrp.GroupSize != DependencyFacade.GetStudentNumber(oldgrp.ID))
            {
                oldgrp.Status = "Open";
                DependencyFacade.UpdateSection(oldgrp);
            }          
        }
    }
}
