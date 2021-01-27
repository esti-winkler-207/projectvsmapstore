using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL1;

namespace DTO
{
    class TimeDTO
    {
        public int idTime { get; set; }
        public string name { get; set; }
        public System.DateTime from { get; set; }
        public System.DateTime until { get; set; }

        //convert

        //1
        public static time fromDTOtoDAL(TimeDTO t)
        {
            time t1 = new time();
            t1.idTime = t.idTime;
            t1.name = t.name;
            t1.from = t.from;
            t1.until = t.until;
            return t1;
        }

        //2
        public static TimeDTO fromDALtoDTO(time t)
        {
            TimeDTO t1 = new TimeDTO();
            t1.idTime = t.idTime;
            t1.name = t.name;
            t1.from = t.from;
            t1.until = t.until;
            return t1;
        }
        //3
        public static List<time> fromDTOtoDAL(List<TimeDTO> li)
        {
            List<time> li1 = new List<time>();
            foreach (var item in li)
            {
                li1.Add(fromDTOtoDAL(item));
            }
            return li1;
        }
        //4
        public static List<TimeDTO> fromDALtoDTO(List<time> li)
        {
            List<TimeDTO> li1 = new List<TimeDTO>();
            foreach (var item in li)
            {
                li1.Add(fromDALtoDTO(item));
            }
            return li1;
        }
    }
}
