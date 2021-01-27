using DAL1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BLL

{
    public class PersonBLL
    {
        static DataEntities7 MyDB = new DataEntities7();

        //GetAllPerson
        public static List<PersonDTO> GetAll()
        {
            return PersonDTO.fromDALtoDTOL(MyDB.Person.ToList());
        }

        //AddPerson
        public static List<PersonDTO> Post(DAL1.Person u)
        {
            try
            {
                using (DataEntities7 MyDB = new DataEntities7())

                {
                    MyDB.Person.Add(u);
                    MyDB.SaveChanges();
                    return PersonDTO.fromDALtoDTOL(MyDB.Person.ToList());
                }
            }
            catch(Exception e) { throw e; }
        }

        //DeleteUser/{id}
        public static List<PersonDTO> Delete(int id)
        {
            var item = MyDB.Person.Find(id);
            MyDB.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            MyDB.SaveChanges();
            return PersonDTO.fromDALtoDTOL(MyDB.Person.ToList());
        }

        //UpdateUser
        public static List<PersonDTO> Put(DAL1.Person u)
        {
            //גם פה בעיה עם ה ADD
            MyDB.Set<DAL1.Person>().Add(u);
            MyDB.SaveChanges();
            return PersonDTO.fromDALtoDTOL(MyDB.Person.ToList());
        }
        //FindUser
        public static int Get(string password, string userName)
        {
            var item = MyDB.Person.FirstOrDefault(u1 => u1.Name == userName && u1.Pwd == password);
            if (item==null)
            {
                return 0;
            }
            return 1;
        }


    }
}
