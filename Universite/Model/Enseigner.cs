using System.ComponentModel.DataAnnotations;

namespace Universite.Model
{
    public class Enseigner
    {
        // Clé primaire 
        public int ID { get; set; }

        // Lien de composition vers l'enseignant 
        public int LEnseignantID { get; set; }
        public Enseignant? LEnseignant { get; set; }

        [Display(Name = "UE enseignée")]
        // Lien de composition vers l'UE 
        public int LUEID { get; set; }
        public UE? LUE { get; set; }

    }
}
