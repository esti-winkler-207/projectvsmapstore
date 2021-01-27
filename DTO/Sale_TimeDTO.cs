using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL1;
namespace DTO
{
    class Sale_TimeDTO
    {
        public int idSale { get; set; }
        public int storid { get; set; }
        public System.DateTime start { get; set; }
        public System.DateTime end { get; set; }
        public string saleName { get; set; }
        public string Describe { get; set; }


        //convert

        //1
        public static Sale_Time fromDTOtoDAL(Sale_TimeDTO s)
        {
            Sale_Time s1 = new Sale_Time();
            s1.idSale = s.idSale;
            s1.storid = s.storid;
            s1.end = s.end;
            s1.start = s.start;
            s1.saleName = s.saleName;
            s1.Describe = s.Describe;
            return s1;
        }

        //2
        public static Sale_TimeDTO fromDALtoDTO(Sale_Time s)
        {
            Sale_TimeDTO s1 = new Sale_TimeDTO();
            s1.idSale = s.idSale;
            s1.storid = s.storid;
            s1.end = s.end;
            s1.start = s.start;
            s1.saleName = s.saleName;
            s1.Describe = s.Describe;
            return s1;
        }
        //3
        public static List<Sale_Time> fromDTOLtoDAL(List<Sale_TimeDTO> ls)
        {
            List<Sale_Time> ls1 = new List<Sale_Time>();
            foreach (var item in ls)
            {
                ls1.Add(fromDTOtoDAL(item));
            }
            return ls1;
        }
        //4
        public static List<Sale_TimeDTO> fromDALtoDTOL(List<Sale_Time> sl)
        {
            List<Sale_TimeDTO> sl1 = new List<Sale_TimeDTO>();
            foreach (var item in sl)
            {
                sl1.Add(fromDALtoDTO(item));
            }
            return sl1;
        }
    }
}
