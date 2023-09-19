using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaCadastroVeiculo1
{
    public class Caminhao:Veiculo
    {
        //Atributos
        private int eixos;
        //Contrutor
        public Caminhao(string palca, int ano, int _eixos):base(palca, ano)
        {
            eixos = _eixos;
        }
        //metodos
        public override double Alugar()
        {
            double diaria = ((300 * eixos) - (2023 - Ano) * 50);
            return diaria;
        }
        public int Eixos { get => eixos; set => eixos = value; }
    }
}
