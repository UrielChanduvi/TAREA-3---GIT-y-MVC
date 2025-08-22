using System.ComponentModel.DataAnnotations;
namespace VeterinariaMVC.Models
{
    public class Mascota
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
    public string? Nombre { get; set; }

        [Required(ErrorMessage = "La especie es obligatoria")]
    public string? Especie { get; set; }

        [Required(ErrorMessage = "La raza es obligatoria")]
    public string? Raza { get; set; }

        [Range(0, 100, ErrorMessage = "La edad debe ser entre 0 y 100")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El propietario es obligatorio")]
    public string? Propietario { get; set; }
    }
}