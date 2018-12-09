using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ServisPeter.Models
{
    public class Databaza
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Dátum musí byť zadaný!")]
        [Display(Name = "Dátum prijatia auta")]
        [DataType(DataType.Date, ErrorMessage = "Prosím zadajte dátum, v požadovanom formáte!")]
        public DateTime Datump { get; set; }


        [Required(ErrorMessage = "Dátum musí byť zadaný!")]
        [Display(Name = "Dátum odovzdania auta")]
        [DataType(DataType.Date, ErrorMessage = "Prosím zadajte dátum, v požadovanom formáte!")]
        public DateTime datumo { get; set; }

        [Required(ErrorMessage = "Auto musí byť zadané!")]
        public string Auto { get; set; }

        [Required(ErrorMessage = "Typ musí byť zadaný!")]
        public string Typ { get; set; }


        [Required(ErrorMessage = "Kód motora musí byť zadaný!")]
        [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "Prosím zadajte kód motora bez medzier!")]
        [Display(Name = "Kód motora")]
        public string Kod { get; set; }


        [Required(ErrorMessage = "Počet najazdených kilometrov musí byť zadaný!")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Prosím zadajte kilometre bez medzier a písmen!")]
        [Display(Name = "Počet najazdených kilometrov")]
        public double Kilometre { get; set; }


        [Required(ErrorMessage = "ŠPZ musí byť zadaná!")]
        [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "Prosím zadajte ŠPZ bez medzier!")]
        [Display(Name = "ŠPZ")]

        public string SPZ { get; set; }


        [Required(ErrorMessage = "VIN musí byť zadané!")]
        [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "Prosím zadajte VIN číslo bez medzier.")]
        [StringLength(17, MinimumLength = 17, ErrorMessage = "Dĺžka VIN je sedemnásť znakov!")]
        [Display(Name = "VIN")]
        public string WIN { get; set; }

        [Required(ErrorMessage = "Oprava musí byť zadaná!")]
        public string Oprava { get; set; }

        [Required(ErrorMessage = "Cena musí byť zadaná!")]
        [RegularExpression(@"^[0-9.,]*$", ErrorMessage = "Prosím zadajte číslice!")]
        public string Cena { get; set; }

        [Display(Name = "Poznámky")]
        public string Poznamky { get; set; }
    }

}

