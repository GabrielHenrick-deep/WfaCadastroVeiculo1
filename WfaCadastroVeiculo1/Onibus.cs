using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaCadastroVeiculo1
{
    public class Onibus:Veiculo
    {
        //Atributos
        private int assento;
        //Construtor
        public Onibus(string palca, int ano,int _assento):base(palca, ano)
        {
            assento = _assento;
            
        }
        //Metodos
        public override double Alugar()
        {
            double diaria = ((30 * assento) - (2023 - Ano) * 70);
            return diaria;
        }
        public int Assento { get => assento; set => assento = value; }
    }
}//Fim da classe Onibus
