using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula80_WF_
{
    internal class Viagem
    {
        public int Duracao { get; set; }
        public double Valor { get; set; }

        List<Viagem> ViagemLista = new List<Viagem>();


        public Viagem(int duracao)
        {
            Duracao = duracao;
        }
        public void ValorViagem()
        {
            Valor = Duracao * 0.8;
        }

        
    }
}
