sing System;

class Program {
    
   public struct carro{
     public string nmveiculo;
     public double anoveiculo;
     public string corveiculo;
     public string menu;
   
      static void Main(string[] args){
     
      
       if(  < 2022){
       const int nao = 5;
       carro[] carro = new carro[nao]; for (int x = 0; x < 2; x++){
       Console.WriteLine("Modelo do {0}º Veiculo", x + 1);
        carro[x].nmveiculo = Console.ReadLine();
         Console.WriteLine("Ano do {0}º Veiculo", x + 1);
         carro[x].anoveiculo = double.Parse(Console.ReadLine());
         Console.WriteLine("Cor do {0}º Veiculo", x + 1);
         carro[x].corveiculo = Console.ReadLine();
         Console.Clear();
       }
     }
     else{
         Console.WriteLine("Ano invalido");
         Console.ReadLine();
       }
     for (int x = 0; x < 5; x++)
{
     Console.WriteLine("Nome do {0}º veiculo: {1}", x+1, carro[x].nmveiculo);
       Console.WriteLine("Ano do {0}º veiculo: {1}", x+1, carro[x].anoveiculo);
       Console.WriteLine("Cor do {0}º veiculo: {1}", x+1, carro[x].corveiculo);
       Console.ReadLine();
   }
     }
    }
}