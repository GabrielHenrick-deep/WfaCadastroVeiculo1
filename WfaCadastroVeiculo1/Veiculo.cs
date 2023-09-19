using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaCadastroVeiculo1
{
    public abstract class Veiculo
    {
        //Atributos
        private string placa;
        private int ano;
        //Construtor
        public Veiculo(string _placa, int _ano)
        {
            placa = _placa;
            ano = _ano;
        }

        //Metodos
        public virtual double Alugar()
        {

            return 0.0;
        }
        public string Placa { get => placa; set => placa = value; }
        public int Ano { get => ano; set => ano = value; }
        

    }
}
