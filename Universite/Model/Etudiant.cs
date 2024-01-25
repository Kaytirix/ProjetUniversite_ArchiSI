using System.ComponentModel.DataAnnotations;

namespace Universite.Model
{
    public class Etudiant
    {
        [Key]
        public int ID { get; set; }

       [Display(Name = "Nom")]
        [Required]
        public string? Nom { get; set; }

        [Display(Name = "Prénom")]
        [Required]
        public string? Prenom { get; set; }

        [Display(Name = "Date Naissance")]
        [DataType(DataType.Date)]
        public DateTime Naissance { get; set; }

        [Display(Name = "Numéro étudiant")]
        [Required]
        public string NumeroEtudiant { get; set; }

        // Clé étrangère vers la formation suivie
        // Porte le nom du lien de navigation suivi du nom de la clé primaire de Formation
        public int? FormationSuivieID { get; set; }

        // Lien de navigation
        public Formation? FormationSuivie { get; set; }

    }
}
