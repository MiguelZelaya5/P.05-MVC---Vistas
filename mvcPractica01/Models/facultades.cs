using System.ComponentModel.DataAnnotations;

namespace mvcPractica01.Models
{
    public class facultades
    {
        [Key]
        [Display(Name = "ID")]
        public int facultad_id { get; set; }
        [Display(Name = "NOMBRE DE FACULTAD")]
        public string nombre_facultad { get; set; }
    }
}
