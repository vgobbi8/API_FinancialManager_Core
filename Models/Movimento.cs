using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_FinancialManager_Core.Utils;

namespace API_FinancialManager_Core.Models
{
    public class Movimento
    {
        public long Id { get; set; }
        public long ContaId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; } 
        public DateTime DataMovimento { get; set; }
        public EnumTypes.TipoDeMovimento TipoDeMovimento { get; set; }


        public void teste()
        {
            //int a = this.Codigo;
            string b = this.Descricao;
          //  double d = this.Valor;
            //Enums.TiposMovimento c = this.TipoMovimento;
            //DateTime e = this.DataMovimento;
        
            this.Descricao = "PASSOU PELA API";
            this.Valor = 1000;
        }
    }
}
