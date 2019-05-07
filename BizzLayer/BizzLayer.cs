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

        public static void UpdateStudents(Users user)
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
    }
}
