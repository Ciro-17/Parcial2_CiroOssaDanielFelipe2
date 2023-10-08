﻿using System.ComponentModel.DataAnnotations;

namespace Parcial2_CiroOssaDanielFelipe2.DAL.Entities
{
    public class NaturalPerson : Entity
    {
        [Display(Name = "Nombre Completo")]
        [Required]
        public String FullName { get; set; }

        [Display(Name = "Correo Electronico")]
        [Required]
        public String Email { get; set; }

        [Display(Name = "Año de Nacimiento")]
        [Required]
        public DateTime? BirthYear { get; set; }

        [Display(Name = "Edad")]
        [MaxLength(3, ErrorMessage = "The field {0} must have a maximum of {1} characters")]
        public int Age { get; set; }
    }
}
