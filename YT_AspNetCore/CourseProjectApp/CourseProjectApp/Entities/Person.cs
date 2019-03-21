using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.Entities
{
    public class Person
    {
        // Postavljanje primarnog kljuca putem data anotacija
        [Key] 
        public int PersonId { get; set; }

        [Column("FirstName", TypeName = "varchar(300)")]
        public string FirstName { get; set; }

        public string DisplayName { get; set; }

        [ConcurrencyCheck] //Putem data anotacija, osigurava da niko drugi ne mijenja podatke dok korisnik spasava promjene

        [Column("FirstName", TypeName = "varchar(300)")]
        public string LastName { get; set; }

        [Timestamp] //row versioning /verzioniranje reda, koristi se kod ConcurencyChecka, dobija se exception ako neko pokusa modificirati red koji pokusavate azurirati
        public byte[] TimeStamp { get; set; }



        // [NotMapped] 
        public List<Address> Addresses { get; set; }
    }
}
