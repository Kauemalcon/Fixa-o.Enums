using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixação.Enums.Entities
{
    class Cliente
    {
        public string  Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataAniversario { get; set; }
        

        public Cliente()
        {

        }

        public Cliente(string nome, string email, DateTime dataAniversario)
        {
            Nome = nome;
            Email = email;
            DataAniversario = dataAniversario;
        }

        public override string ToString()
        {
            return Nome + ", Email: " + Email + ", Data aniversario: " + DataAniversario.ToString("dd/MM/yyyy");
        }
    }
}
