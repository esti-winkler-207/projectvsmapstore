﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL1;
using DTO;

namespace BLL
{
    public class PlaceBLL
    {
        static DataEntities7 MyDB = new DataEntities7();

        //GetAllUser
        public static List<PlaceDTO> GetAll()
        {
            return PlaceDTO.fromDALtoDTOL(MyDB.Place.ToList());
        }

        //AddUser
        public static List<PlaceDTO> Post(DAL1.Place u)
        {
            using (DataEntities7 MyDB = new DataEntities7())

            {
                try {
                    DAL1.prop p1 = new DAL1.prop();
                    p1.idPlace = u.idPlace;
                   MyDB.Place.Add(u);
                    MyDB.SaveChanges();
                   //MyDB.prop.Add(p1);
                   // MyDB.SaveChanges();

                    
                     return PlaceDTO.fromDALtoDTOL(MyDB.Place.ToList()); }
                     catch (Exception e) { throw e; }
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
