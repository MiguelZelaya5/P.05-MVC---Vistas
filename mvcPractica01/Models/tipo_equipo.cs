using System.ComponentModel.DataAnnotations;

namespace mvcPractica01.Models
{
    public class tipo_equipo{ 

        [Key]
        [Display(Name = "ID")]
        public int id_tipo_equipo { get; set; }
        [Display(Name = "DESCRIPCION DEL TIPO DE EQUIPO")]
        public string descripcion { get; set; }
        [Display(Name = "ESTADO")]
        public string estado { get; set; }
    }
}
