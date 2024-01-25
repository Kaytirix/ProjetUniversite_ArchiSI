using System.ComponentModel.DataAnnotations;

namespace Universite.Model
{
    public class UE
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Numero { get; set; }

        [Required]
        public string Intitule { get; set; }
    }
}
