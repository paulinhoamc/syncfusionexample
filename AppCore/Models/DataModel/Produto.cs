using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppCore.Models.DataModel
{
    public class Produto
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50, ErrorMessage = "Máximo de 50 caracteres")]
        public string Nome { get; set; }
        
        public decimal Estoque { get; set; }
        
        public decimal Valor { get; set; }
        
        public bool Ativo { get; set; }
        
        public string Notas { get; set; }
    }
}
