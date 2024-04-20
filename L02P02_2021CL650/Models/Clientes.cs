using System.ComponentModel.DataAnnotations;

namespace L02P02_2021CL650.Models
{
    public class Clientes
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Nombre")]
        public string? nombre { get; set; }

        [Display(Name = "Apellido")]
        public string? apellido { get; set; }

        [Display(Name = "Email")]
        public string? email { get; set; }

        [Display(Name = "Dirección")]
        public string? direccion { get; set; }

        [Display(Name = "Fecha de creación")]
        public DateTime? created_at { get; set; }
    }
}
