using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL1;

namespace BLL

{
    public class informationBLL 
    {//עשיתי משהו שונה ואני לא זוכרת למה קישרתי את הכל לקלאס ושם עשיתי את החיבור עם 
        //המסד אין לי מושג למה עשיתי את זה ואם זה בכלל הדרך הנכונה אז צריך לעבור על זה
        static DataEntities771 MyDB = new DataEntities771();

        //GetInformation
        public static List<DTO.InformationDTO> GetAll()
        {
            
             return InformationDTO.fromDALtoDTO(DAL1.Class1.getAll());
        }
        //AddInformation
        public static List<InformationDTO> Post(DAL1.information u)
        {
           MyDB.information.Add(u);
            MyDB.SaveChanges();
            return InformationDTO.fromDALtoDTO(DAL1.Class1.AddInformation());
        }
        //DeleteInformation/{id}
        public static List<InformationDTO> Delete(int id)
        {
            var item = MyDB.information.Find(id);
            MyDB.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            MyDB.SaveChanges();
            
            return InformationDTO.fromDALtoDTO(DAL1.Class1.DeleteInformation());
        }
        //UpdateInformation
        public static List<InformationDTO> Put(DAL1.information u)
        {
            //לא עבד לי ה AddOrUpdate
            MyDB.Set<DAL1.information>().Add(u);
            MyDB.SaveChanges();
            return InformationDTO.fromDALtoDTO(DAL1.Class1.UpdateInformation());
        }

        //FindInformation
        //הסתבך לי עם הפונקציה הזו כי אין לי שם וסיסמא
        //public static information Get(string password, string userName)
        //{
        //    var item = MyDB.information.Where(u1 => u1.NameUser == userName && u1.Password == password).ToList();
        //    if (item.Count() != 0)
        //    {
        //        var item2 = UserDTO.ConvertUserToDTO(item);

        //        return item2[0];
        //    }
        //    return null;
        //}


    }
}
