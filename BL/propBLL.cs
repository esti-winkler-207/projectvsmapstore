using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL1;
using DTO;

namespace BLL
{
    public class propBLL
    {
        static DataEntities771 MyDB = new DataEntities771();

        //GetAllUser
        public static List<propDTO> GetAll()
        {
            return propDTO.fromDALtoDTOL(MyDB.prop.ToList());
        }

        //AddUser
        public static List<propDTO> Post(DAL1.prop u)
        {
            MyDB.prop.Add(u);
            MyDB.SaveChanges();
            return propDTO.fromDALtoDTOL(MyDB.prop.ToList());
        }

        //DeleteUser/{id}
        public static List<propDTO> Delete(int id)
        {
            var item = MyDB.prop.Find(id);
            MyDB.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            MyDB.SaveChanges();
            return propDTO.fromDALtoDTOL(MyDB.prop.ToList());
        }

        //UpdateUser
        public static List<propDTO> Put(DAL1.prop u)
        { 
            MyDB.Set<DAL1.prop>().Add(u);
            MyDB.SaveChanges();
            return propDTO.fromDALtoDTOL(MyDB.prop.ToList());
        }
        //FindUser
        //
        //public static int Get(int id, string pname)
        //{
        //    var item = MyDB.prop.FirstOrDefault(u1 => u1.idPlace == id);
        //    //להוסיף בשליפה גם לפי שם
        //    if (item==null)
        //    {
        //        return 0;
        //    }
        //    return 1;

        //}

    }
}
