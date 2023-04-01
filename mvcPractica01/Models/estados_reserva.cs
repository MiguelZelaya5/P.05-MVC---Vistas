using System.ComponentModel.DataAnnotations;

namespace mvcPractica01.Models
{
    public class estados_reserva
    {
        [Key]
        [Display(Name = "ID")]
        public int estado_res_id { get; set; }
        [Display(Name = "ESTADO")]
        public string estado { get; set; }

    }
}
