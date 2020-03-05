using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_FinancialManager_Core.Utils;
namespace API_FinancialManager_Core.Models
{
    public class Conta
    {
        public long Id { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string NrDaConta { get; set; }
        public string Descricao { get; set; }
        public EnumTypes.TipoDeConta TipoDeConta { get; set; }
        public List<Movimento> ListaMovimentos { get; set; }
    }
}
