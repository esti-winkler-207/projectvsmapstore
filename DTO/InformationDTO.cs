using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL1;

namespace DTO
{
   public class InformationDTO
    {
        public int idPlace { get; set; }
        public int idTime { get; set; }
        public System.TimeSpan from { get; set; }
        public System.TimeSpan until { get; set; }
        public int numPepol { get; set; }
        public int avg { get; set; }
        public int stieeeeeeee { get; set; }
        public int max { get; set; }
        public int min { get; set; }
        public string timeofYaer { get; set; }
        public string commend { get; set; }



        //convert
        
        //1
        public static information fromDTOtoDAL(InformationDTO i)
        {
           information i1 = new information();
            i1.idPlace= i.idPlace;
            i1.idTime = i.idTime;
            i1.numPepol = i.numPepol;
            i1.avg = i.avg;
            i1.stieeeeeeee = i.stieeeeeeee;
            i1.max = i.max;
            i1.min = i.min;
            i1.timeofYaer = i.timeofYaer;
            i1.commend = i.commend;
            return i1;
        }

        //2
        public static InformationDTO fromDALtoDTO(information i)
        {
            InformationDTO i1 = new InformationDTO();
            i1.idPlace = i.idPlace;
            i1.idTime = i.idTime;
            i1.numPepol = i.numPepol;
            i1.avg = i.avg;
            i1.stieeeeeeee = i.stieeeeeeee;
            i1.max = i.max;
            i1.min = i.min;
            i1.timeofYaer = i.timeofYaer;
            i1.commend = i.commend;
            return i1;
        }
        //3
        public static List<information> fromDTOtoDAL(List<InformationDTO> li)
        {
            List<information> li1 = new List<information>();
            foreach (var item in li)
            {
                li1.Add(fromDTOtoDAL(item));
            }
            return li1;
        }
        //4
        public static List<InformationDTO> fromDALtoDTO(List<information> li)
        {
            List<InformationDTO> li1 = new List<InformationDTO>();
            foreach (var item in li)
            {
                li1.Add(fromDALtoDTO(item));
            }
            return li1;
        }

    }

}
