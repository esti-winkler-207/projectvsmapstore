using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1
{
   public class PersonDAL
   {

        public static Person getByNameAndPwd(Person person)
        {
            using (DataEntities771 db = new DataEntities771())
            {
                //for (int i = 0; i < db.information.Count(); i++)
                //{
                //    if (db.Person.ToList()[i].Name == name && db.Person.ToList()[i].Pwd == pwd)
                //        return db.Person.ToList()[i];
                //    else
                //        return 0;
                //}
                //return db.Person.ToList();
                Person p = db.Person.FirstOrDefault(x => x.Name == person.Name && x.Pwd == person.Pwd);
                return p;
            }
        }

        public static object check_user(string name, string password)
        {
            throw new NotImplementedException();
        }

        public static object Select_users_bynamePass(string name, string password)
        {
            throw new NotImplementedException();
        }

        //בדיקה האם משתמש קיים עפ"י שם וסיסמא
        public static Person Check_user(string Password, string username)
        {

            using (DataEntities771 db = new DataEntities771())
            {
                Person user = db.Person.FirstOrDefault(p => p.Pwd == Password && p.Name == username);
                return user;

            }
        }

   }   
}
