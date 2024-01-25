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

        public int? FormationAttacheID { get; set; }

        public Formation? FormationAttache { get; set; }

        // Lien de navigation ManyToMany 
        [Display(Name = "Enseignants de l’UE")]
        public ICollection<Enseigner> LesEnseigner { get; set; }

    }
}
