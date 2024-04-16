using ICE_Repository.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repository.Models
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public Country CountryId { get; set; }
    }
}
