using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ServisPeter.Models
{
    public class Pozns
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Dátum musí byť zadaný!")]
        [Display(Name = "Dátum vytvorenia")]
        [DataType(DataType.Date, ErrorMessage = "Prosím zadajte dátum, v požadovanom formáte!")]
        public DateTime Datum { get; set; }

        [Required(ErrorMessage = "Názov musí byť zadaný!")]
        [Display(Name = "Názov poznámky")]
        public string Nazov { get; set; }


        [Required(ErrorMessage = "Predmet musí byť zadaný!")]
        [Display(Name = "Predmet poznámky")]
        public string Predmet { get; set; }


        [Required(ErrorMessage = "Text musí byť zadaný!")]
        [Display(Name = "Text poznámky")]
        public string Text { get; set; }
    }
}
