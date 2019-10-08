using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }
        public DateTime DtCadastro { get; set; }
    }
}
