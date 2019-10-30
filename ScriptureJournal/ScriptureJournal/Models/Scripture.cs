using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScriptureJournal.Models
{
    public enum BookName
    {
        FirstNephi,
        SecondNephi,
        Jacob,
        Enos,
        Jarom,
        Omni,
        WordsOfMormon,
        Mosiah,
        Alma,
        Helaman,
        ThirdNephi,
        FourthNephi,
        Mormon,
        Ether,
        Moroni

    }
    public class Scripture
    {
        public int ID { get; set; }

        [Display(Name = "Book Name")]
        [EnumDataType(typeof(BookName))]
        public BookName Book { get; set; }

        public int Chapter { get; set; }
        public int Verse { get; set; }
        public string Notes { get; set; }
    }
}
