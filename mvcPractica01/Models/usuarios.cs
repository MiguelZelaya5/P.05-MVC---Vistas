﻿using System.ComponentModel.DataAnnotations;

namespace mvcPractica01.Models
{
    public class usuarios
    {
        [Key]
        [Display(Name = "ID")]
        public int usuario_id { get; set; }
        [Display(Name = "NOMBRE")]
        public string nombre { get; set; }
        [Display(Name = "DOCUMENTO")]
        public string documento { get; set; }
        [Display(Name = "TIPO")]
        public string tipo { get; set; }
        [Display(Name = "CARNET")]
        public string carnet { get; set; }
        [Display(Name = "CARRERA ID")]
        public int carrera_id { get; set; }
    }
}
