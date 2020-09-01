using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vozila.Model
{
    public class Vozilo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Marka { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Tip { get; set; }
        [Required]
        public string Sasija { get; set; }
    }
}
