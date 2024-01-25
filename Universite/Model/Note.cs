using System.ComponentModel.DataAnnotations;

namespace Universite.Model
{
    public class Note
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public float Valeur { get; set; }
    }
}
