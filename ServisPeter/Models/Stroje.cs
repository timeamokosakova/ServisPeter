using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ServisPeter.Models
{
    public class Stroje
    {

        public int ID { get; set; }

        [Display(Name = "Názov")]
        [Required(ErrorMessage = "Názov musí byť zadaný!")]
        public string Nazov { get; set; }


        [Display(Name = "Načo slúži daný prístroj")]
        [Required(ErrorMessage = "Typ musí byť zadaný!")]
        public string Typ { get; set; }

        [Display(Name = "Poznámky")]
        public string Poznamky { get; set; }



    }
}
