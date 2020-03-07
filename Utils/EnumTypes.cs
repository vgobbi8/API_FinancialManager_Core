using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_FinancialManager_Core.Utils
{
    public class EnumTypes
    {
        public enum TipoDeConta
        {
            Corrente = 0,
            Poupanca = 1
        }

        public enum TipoDeMovimento
        {
            Entrada = 0,
            Saida = 1
        }
    }
}
