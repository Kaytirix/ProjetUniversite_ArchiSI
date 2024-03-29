﻿using System.ComponentModel.DataAnnotations;

namespace Universite.Model
{
    public class Formation
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Intitule { get; set; }

        [Required]
        public int AnneeDiplome { get; set; }

        // Lien de navigation
        public ICollection<Etudiant>? EtudiantsInscrits { get; set; }

        public ICollection<UE>? UeAttache {  get; set; }

        // Données calculées non persistantes
        // Pas de set
        [Display(Name = "Nombre d'inscrits")]
        public int NbInscrits
        {
            get
            {
                if (EtudiantsInscrits != null)
                    return EtudiantsInscrits.Count;
                else
                    return -1;
            }
        }

        // Données calculées non persistantes
        // Pas de set
        [Display(Name = "Nombre d'EU")]
        public int NbUe
        {
            get
            {
                if (UeAttache != null)
                    return UeAttache.Count;
                else
                    return -1;
            }
        }

    }
}
