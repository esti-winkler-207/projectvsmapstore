using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL1;
using DTO;

namespace BLL
{
    public class PlaceBLL
    {
        static DataEntities771 MyDB = new DataEntities771();

        //GetAllUser
        public static List<PlaceDTO> GetAll()
        {
            return PlaceDTO.fromDALtoDTOL(MyDB.Place.ToList());
        }

        //AddUser
        public static List<PlaceDTO> Post(DAL1.Place u)
        {
            using (DataEntities771 MyDB = new DataEntities771())

            {
                try
                {
                    
                    var p2 = MyDB.Place.FirstOrDefault(p1 => p1.name == u.name);
                    if (p2 != null)
                    {
                       
                        //u.store.Add( new store() 
                        //{
                        //    idPlace=u.idPlace,
                        //    type="store",
                            
                        //});
                         MyDB.Place.Add(u);
                        var s1 = new store();
                        s1.idPlace = u.idPlace;
                        s1.type = "store";
                        MyDB.store.Add(s1);
                        //u.prop.Add(new prop()
                        //{
                            
                        //    Cleandislike = 0,
                        //    Cleanlike=0,
                        //    DParkingdislike=0,
                        //    DParkinglike=0,
                        //    Parkingdislike=0,
                        //    Parkinglike=0,
                        //    Elevatordislike=0,
                        //    Eleveterlike=0,
                        //    Negisotlike=0,
                        //    Negisotdislike=0,
                        //    //need to change id_sale & id_store
                        //    id_sale=1,
                        //    id_store=1

                        //}
                        //) ;
                        
                        MyDB.SaveChanges();
                        //DAL1.prop p1 = new DAL1.prop();
                        //p1.idPlace = u.idPlace;
                        //MyDB.prop.Add(p1);
                        //MyDB.SaveChanges();
                    }
                    //MyDB.prop.Add(p1);
                    //MyDB.SaveChanges();
                    return PlaceDTO.fromDALtoDTOL(MyDB.Place.ToList()); 
                   
                }

                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;


                }
            }
        }

        //DeleteUser/{id}
        public static List<PlaceDTO> Delete(int id)
        {
            var item = MyDB.Place.Find(id);
            MyDB.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            MyDB.SaveChanges();
            return PlaceDTO.fromDALtoDTOL(MyDB.Place.ToList());
        }

        //UpdateUser
        public static List<PlaceDTO> Put(DAL1.Place u)
        {
            MyDB.Set<DAL1.Place>().Add(u);
            MyDB.SaveChanges();
            return PlaceDTO.fromDALtoDTOL(MyDB.Place.ToList());
        }
        //FindUser
        //
        public static PlaceDTO Get(int id, string pname)
        {
            var item = MyDB.Place.Where(u1 => u1.idPlace == id && u1.name == pname).ToList();
            if (item.Count() != 0)
            {
                var item2 = PlaceDTO.fromDALtoDTOL(item);

                return item2[0];
            }
            return null;
        }

    }
}
