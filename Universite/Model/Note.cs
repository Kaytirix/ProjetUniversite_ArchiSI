using System.ComponentModel.DataAnnotations;

namespace Universite.Model
{
    public class Note
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public float Valeur { get; set; }

        #region Lien entre UE et note
        public int EtudiantID { get; set; }

        public Etudiant Etudiant { get; set; }
        #endregion

        #region Lien entre UE et Note
        public UE UE { get; set; }

        public int UEID { get; set; }
        #endregion
    }
}
