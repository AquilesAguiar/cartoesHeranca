using System;
using System.Collections.Generic;
using cartoesHeranca.cartao;
namespace cartoesHeranca
{
    public class user
    {
        public string nome { get; private set; }
        public string sobreNome{get; private set; }
        
        public List<object> cartoes = new List<object>();

        public user(string Nome, string SobreNome)
        {
            nome = Nome;
            sobreNome = SobreNome;
        }

        public void criarCartao(string tipo,double limite,double saldo){
            switch (tipo)
            {
                case "internacional":
                    cartoes.Add(new internacional(limite, saldo));
                    break;
                case "nacional":
                    cartoes.Add(new nacional(limite, saldo));
                    break;
                default:
                    Console.WriteLine("Erro ao cadastrar");
                    break;
            }
        }

    }
}