using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyAgenda.Models
{
    public class Agenda
    {
        public Guid Id { get; set; }
        
        //--------------Definindo atributos para a Agenda-------------------

        [Required]
        public string Nome { get; set; }
        [Required]
        public int Telefone { get; set; }
        [Required]
        public string Endereco { get; set; }

        public Agenda ()
        {
            Id = Guid.NewGuid();
        }

        
    }
}
