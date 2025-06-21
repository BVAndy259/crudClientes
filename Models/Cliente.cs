using System.ComponentModel.DataAnnotations;

namespace crudClientes.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [Required]
        public string? Nombres { get; set; }
        [Required]
        public string? Apellidos { get; set; }
        [Required]
        public string? Dni { get; set; }
    }
}