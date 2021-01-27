using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL1;

namespace DTO
{
   public class PersonDTO
    {
        public int idperson { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Pwd { get; set; }

        //convert

        //1
        public static Person fromDTOtoDAL(PersonDTO p)
        {
            Person p1 = new Person();
            p1.idperson = p.idperson;
            p1.Email = p.Email;
            p1.Name = p.Name;
            p1.Pwd = p.Pwd;
            return p1;
        }

        //2
        public static PersonDTO  fromDALtoDTO(Person p)
        {
            PersonDTO p1 = new PersonDTO();
            p1.idperson = p.idperson;
            p1.Email = p.Email;
            p1.Name = p.Name;
            p1.Pwd = p.Pwd;
            return p1;
        }
        //3
        public static List<Person> fromDTOLtoDAL(List<PersonDTO> pi)
        {
            List<Person> pi1 = new List<Person>();
            foreach (var item in pi)
            {
                pi1.Add(fromDTOtoDAL(item));
            }
            return pi1;
        }
        //4
        public static List<PersonDTO> fromDALtoDTOL(List<Person> pi)
        {
            List<PersonDTO> pi1 = new List<PersonDTO>();
            foreach (var item in pi)
            {
                pi1.Add(fromDALtoDTO(item));
            }
            return pi1;
        }
    }
}
