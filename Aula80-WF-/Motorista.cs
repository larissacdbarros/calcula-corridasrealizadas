using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula80_WF_
{
    internal class Motorista
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public double ValorTotal { get; set; }
        
        public Viagem Viagem { get; set; }

        public List<Viagem> Viagens = new List<Viagem>();

        public List<Motorista> Motoristas= new List<Motorista>();

        //public Motorista(string nome, string cpf)
        //{
        //    Nome = nome;
        //    Cpf = cpf;
        //}

        public void Viajar(Viagem viagem)
        {
            Viagens.Add(viagem);
        }

        

    }



    
}
