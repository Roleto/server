using System.ComponentModel.DataAnnotations;

namespace HitelCalc.Models
{
    public class HitelModel
    {
        [Required]
        public string Nev { get; set; }
        [Required]
        [Range(5,40, ErrorMessage = "A kamat minimum 5% maximum 40%" )]
        public double R { get; set; }
        [Required]
        [Range(100000,999999)]
        public int PV{ get; set; }
        [Required]
        [Range(3,30)]
        public int T{ get; set; }
    }
}
