using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.Entities
{
    public class Car
    {
      //  [DatabaseGenerated(DatabaseGeneratedOption.None)] // koristi se kako baza ne bi kreirala vrijednost za ovo polje
        public int CarId { get; set; }
        public string CarColor { get; set; }
        public int Year { get; set; }


        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)] // Na insert ili update ce svaki put dodati vrijednost, u ovom slucaju datetime
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Samo na insert ce svaki put dodati vrijednost, u ovom slucaju datetime

        public DateTime Datum { get; set; }
    }
}
