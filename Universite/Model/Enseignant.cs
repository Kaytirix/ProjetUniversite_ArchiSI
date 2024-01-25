using System.ComponentModel.DataAnnotations;

namespace Universite.Model
{
    public class Enseignant
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }

        // Lien ManyToMany 
        [Display(Name = "UEs Enseignées")]
        public ICollection<Enseigner> LesEnseigner { get; set; }

    }
}
