using System.ComponentModel.DataAnnotations;

namespace mvcPractica01.Models
{
    public class Estados_equipo { 


        [Key]
        [Display(Name = "ID")]
        public int id_estados_equipo { get; set; }
        [Display(Name = "DESCRIPCION")]
        public string descripcion { get; set; }
        [Display(Name = "ESTADO")]
        public string  estado { get; set; }
    }
}
