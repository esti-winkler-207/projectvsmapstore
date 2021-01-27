using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL1;

namespace DTO
{
    public class PlaceDTO
    {
        public int idPlace { get; set; }
        public string name { get; set; }
        public double lat { get; set; }
        public double lan { get; set; }

        //convert

        //1
        public static Place fromDTOtoDAL(PlaceDTO p)
        {
            Place p1 = new Place();
            p1.idPlace = p.idPlace;
            p1.name = p.name;
            p1.lat = p.lat;
            p1.lan = p.lan;
            return p1;
        }

        //2
        public static PlaceDTO fromDALtoDTO(Place p)
        {
            PlaceDTO p1 = new PlaceDTO();
            p1.idPlace = p.idPlace;
            p1.name = p.name;
            p1.lat = p.lat;
            p1.lan = p.lan;
            return p1;
        }
        //3
        public static List<Place> fromDTOLtoDAL(List<PlaceDTO> li)
        {
            List<Place> li1 = new List<Place>();
            foreach (var item in li)
            {
                li1.Add(fromDTOtoDAL(item));
            }
            return li1;
        }
        //4
        public static List<PlaceDTO> fromDALtoDTOL(List<Place> pi)
        {
            List<PlaceDTO> pi1 = new List<PlaceDTO>();
            foreach (var item in pi)
            {
                pi1.Add(fromDALtoDTO(item));
            }
            return pi1;
        }
    }
}
