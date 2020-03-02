using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_FinancialManager_Core.Models
{
    public class MovimentoModel
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }


        public void teste()
        {
            int a = this.Codigo;
            string b = this.Descricao;
            double d = this.Valor;
            //Enums.TiposMovimento c = this.TipoMovimento;
            //DateTime e = this.DataMovimento;
            this.Codigo = 100;
            this.Descricao = "PASSOU PELA API";
            this.Valor = 1000;
        }
    }
}
