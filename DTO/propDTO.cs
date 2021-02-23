using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL1;

namespace DTO
{
  public   class propDTO
    {
        public int Cleanlike { get; set; }
        public int Parkinglike { get; set; }
        public int DParkinglike { get; set; }
        public int Eleveterlike { get; set; }
        public int Negisotlike { get; set; }
        public int id_sale { get; set; }
        public int id_store { get; set; }
        
        public int Cleandislike { get; set; }
        public int Parkingdislike { get; set; }
        public int DParkingdislike { get; set; }
        public int Elevatordislike { get; set; }
        public int Negisotdislike { get; set; }


        //convert

        //1
        public static prop fromDTOtoDAL(propDTO p)
        {
            prop p1 = new prop();
            p1.Cleandislike=p.Cleandislike;
            p1.Cleanlike = p.Cleanlike;
            p1.DParkingdislike = p.DParkingdislike;
            p1.DParkinglike = p1.DParkinglike;
            p1.Elevatordislike = p1.Elevatordislike;
            p1.Eleveterlike = p1.Eleveterlike;
            p1.id_sale = p.id_sale;
            p1.id_store = p.id_store;
            
            return p1;
        }

        //2
        public static propDTO fromDALtoDTO(prop p)
        {
            propDTO p1 = new propDTO();
            p1.Cleandislike = p.Cleandislike;
            p1.Cleanlike = p.Cleanlike;
            p1.DParkingdislike = p.DParkingdislike;
            p1.DParkinglike = p1.DParkinglike;
            p1.Elevatordislike = p1.Elevatordislike;
            p1.Eleveterlike = p1.Eleveterlike;
            p1.id_sale = p.id_sale;
            p1.id_store = p.id_store;
            
            return p1;
        }
        //3
        public static List<prop> fromDTOLtoDAL(List<propDTO> pi)
        {
            List<prop> pi1 = new List<prop>();
            foreach (var item in pi)
            {
                pi1.Add(fromDTOtoDAL(item));
            }
            return pi1;
        }
        //4
        public static List<propDTO> fromDALtoDTOL(List<prop> pi)
        {
            List<propDTO> pi1 = new List<propDTO>();
            foreach (var item in pi)
            {
                pi1.Add(fromDALtoDTO(item));
            }
            return pi1;
        }
    }
}
