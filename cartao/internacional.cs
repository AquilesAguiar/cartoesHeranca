using System;
namespace cartoesHeranca.cartao
{
    public class internacional:cartao
    {
        
        public internacional(double Limite,double Saldo){
            limite=Limite;
            saldo=Saldo;
            fatura=false;
            valorFatura=0;
        }

        public override void comprar(string tipo,double valor)
        {
            switch (tipo){
                case "debito":
                    if (valor<=saldo){
                        saldo-=(valor*0.05);
                        Console.WriteLine("Compra realizada");
                        break;
                    }
                    Console.WriteLine("Saldo insuficiente");
                    break;
                    
                   
                case "credito":
                    if(fatura!=true){
                        if(valor<=limite)
                        {
                            limite-=valor;
                            compras.Add(valor);
                            Console.WriteLine("Compra realizada");
                            break;
                        }
                        Console.WriteLine("Limite abaixo");
                    }
                    Console.WriteLine("Fatura aberta,impossivel realizar");
                    break;
                default:
                    Console.WriteLine("Compra não realizada tente novamente");
                    break;
                
            }
        }
        public override void comprar(double valor)
        {
            if(fatura!=true){
                if(valor<=limite)
                {
                    limite-=valor;
                    compras.Add(valor);
                    Console.WriteLine("Compra realizada");
                    
                }
                Console.WriteLine("Limite abaixo");
            }
            Console.WriteLine("Fatura aberta,impossivel realizar");
        }
        
    }
}