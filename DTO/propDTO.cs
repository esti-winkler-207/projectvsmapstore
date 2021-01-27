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
        public bool AC { get; set; }
        public bool Parking { get; set; }
        public bool DParking { get; set; }
        public bool Eleveter { get; set; }
        public string Negisot { get; set; }
        public int id_sale { get; set; }
        public int id_store { get; set; }
        public int idPlace { get; set; }



        //convert

        //1
        public static prop fromDTOtoDAL(propDTO p)
        {
            prop p1 = new prop();
            p1.AC = p.AC;
            p1.Parking = p.Parking;
            p1.DParking = p.DParking;
            p1.Eleveter = p.Eleveter;
            p1.Negisot = p.Negisot;
            p1.id_sale = p.id_sale;
            p1.id_store = p.id_store;
            p1.idPlace = p.idPlace;
            return p1;
        }

        //2
        public static propDTO fromDALtoDTO(prop p)
        {
            propDTO p1 = new propDTO();
            p1.AC = p.AC;
            p1.Parking = p.Parking;
            p1.DParking = p.DParking;
            p1.Eleveter = p.Eleveter;
            p1.Negisot = p.Negisot;
            p1.id_sale = p.id_sale;
            p1.id_store = p.id_store;
            p1.idPlace = p.idPlace;
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
