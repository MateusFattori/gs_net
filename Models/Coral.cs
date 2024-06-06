using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using gs_net.Models;
using System;
using System.Collections.Generic;
namespace gs_net.Models
{
    [Table("Corais")]
    public class Coral
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Nome { get; set; }

        [Required]
        [StringLength(300)]
        public string Especie { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [ForeignKey("Projeto")]
        public int ProjetoId { get; set; }
        public Projeto Projeto { get; set; }
        public ICollection<Localizacao> Localizacoes { get; set; }
    }
}
