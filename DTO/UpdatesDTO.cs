using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL1;
namespace DTO
{
    class UpdatesDTO
    {
        public int idUpdats { get; set; }
        public int idPlace { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan time { get; set; }
        public int count { get; set; }
        public int ip { get; set; }
        public string ps { get; set; }
        public int idSale { get; set; }

        //convert

        //1
        public static Updates  fromDTOtoDAL(UpdatesDTO u)
        {
            Updates u1 = new Updates();
            u1.idUpdats = u.idUpdats;
            u1.idPlace = u.idPlace;
            u1.Date = u.Date;
            u1.time = u.time;
            u1.count = u.count;
            u1.ip = u.ip;
            u1.ps = u.ps;
            u1.idSale = u.idSale;
            return u1;
        }

        //2
        public static UpdatesDTO fromDALtoDTO(Updates u)
        {
            UpdatesDTO u1 = new UpdatesDTO();
            u1.idUpdats = u.idUpdats;
            u1.idPlace = u.idPlace;
            u1.Date = u.Date;
            u1.time = u.time;
            u1.count = u.count;
            u1.ip = u.ip;
            u1.ps = u.ps;
            u1.idSale = u.idSale;
            return u1;
            
        }
        //3
        public static List<Updates> fromDTOtoDAL(List<UpdatesDTO> li)
        {
            List<Updates> li1 = new List<Updates>();
            foreach (var item in li)
            {
                li1.Add(fromDTOtoDAL(item));
            }
            return li1;
        }
        //4
        public static List<UpdatesDTO> fromDALtoDTO(List<Updates> li)
        {
            List<UpdatesDTO> li1 = new List<UpdatesDTO>();
            foreach (var item in li)
            {
                li1.Add(fromDALtoDTO(item));
            }
            return li1;
        }

    }
}
