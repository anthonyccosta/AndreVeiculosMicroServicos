using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Models
{
    public class PendenciaFinanceira
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public DateTime DataCobranca { get; set; }
        public Cliente Cliente { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; } // Pendente = true, Pago = false
        public DateTime DataPendencia { get; set; }
        public bool TermoUso { get; set; }
        public DateTime DataAceite { get; set; }
        public Cliente Dependente { get; set; } 
    }
}