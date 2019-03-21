using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.Entities
{
    //Mapiranje klase u bazu u tabelu proizvoljnog imena, po defaultu asocira ime klase
    //[Table("Addresses")]

    //Dodavanje specificne seme
    //[Table("Addresses",Schema ="Address")]

    public class Address
    {
        public int AddressId { get; set; }

        //Mapiranje property-a u kolonu proizvoljnog imena,
        //po defaultu asocira se ime property-a u klasi
        //Drugi parametar je proizvoljni tip, kako bi se prepisao defaultni tip koji asocira .net

        [Column("Ulica",TypeName="varchar(300)")]
        public string StreetName { get; set; }

        //[Required] kroz anotacije
        public string City { get; set; }

        public string State { get; set; }

        //  [MaxLength(5)] kroz anotacije
        public string ZipCode { get; set; }

        public int PersonId { get; set; }
        public Person MyPerson { get; set; }
    }
}
