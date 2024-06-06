using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using gs_net.Models;
namespace gs_net.Models
{
    [Table("Localizacoes")]
    public class Localizacao
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Latitude { get; set; }

        [Required]
        public string Longitude { get; set; }

        [ForeignKey("Coral")]
        public int CoralId { get; set; }
        public Coral Coral { get; set; }
    }
}
