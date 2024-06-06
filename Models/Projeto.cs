using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using gs_net.Models;
using System;
using System.Collections.Generic;
namespace gs_net.Models
{
    [Table("Projeto")]
    public class Projeto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public ICollection<Coral> Corais { get; set; }
    }
}
