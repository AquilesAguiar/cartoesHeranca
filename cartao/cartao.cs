using System;
using System.Collections.Generic;
namespace cartoesHeranca.cartao
{
    public abstract class cartao
    {
        public double limite{get; protected set;}
        public double saldo{get; protected set;}
        public bool fatura{get; protected set;}
        public double valorFatura{get; protected set;}

        protected List<double> compras = new List<double>();

        public abstract void comprar(string tipo,double valor);
        public abstract void comprar(double valor);

        public void fecharFatura()
        {
            for (int i = 0; i < compras.Count; i++)
            {
                valorFatura+=compras[i];
            }
            fatura = true;
        }
        public void pagarFatura(double valor)
        {
            if(valor >= valorFatura)
            {
                valorFatura-=valor;
                fatura = false;
                Console.WriteLine("Sobrou"+valorFatura+"do seu pagamento");
            }
            else{
                valorFatura-=valor;
                fatura = true;
                Console.WriteLine("Faltam"+valorFatura+"para fatura ser paga");
            }
        }

    }
}