{\rtf1\ansi\deff0\nouicompat{\fonttbl{\f0\fnil\fcharset0 Calibri;}}
{\*\generator Riched20 10.0.19041}\viewkind4\uc1 
\pard\sa200\sl276\slmult1\f0\fs22\lang22 using System;\par
\par
class Program \{\par
\~ \~ \par
\~ \~public struct carro\{\par
\~ \~ \~public string nmveiculo;\par
\~ \~ \~public double anoveiculo;\par
\~ \~ \~public string corveiculo;\par
\~ \~ \~public string menu;\par
\~ \~\par
\~ \~ \~ static void Main(string[] args)\{\par
\~ \~ \~ int A;\par
      \par
\~ \~ \~ \par
\~ \~ \~ \~ \par
\~ \~ \~ \~const int nao = 5;\par
\~ \~ \~ \~carro[] carro = new carro[nao]; for (int x = 0; x < 5; x++)\{\par
\~ \~ \~ \~Console.WriteLine("Modelo do \{0\}\'ba Veiculo", x + 1);\par
\~ \~ \~ \~carro[x].nmveiculo = Console.ReadLine();\par
\~ \~ \~ \~ \~do\{\par
\~ \~ \~ \~ \~ \~\par
\~ \~ \~ \~ \~\par
\~ \~ \~ \~ \~Console.WriteLine("Ano do \{0\}\'ba Veiculo", x + 1);\par
\~ \~ \~ \~ \~carro[x].anoveiculo = double.Parse(Console.ReadLine());\par
\~ \~ \~ \~ \~if( carro[x].anoveiculo > 2022)\{\par
\~ \~ \~ \~ \~ \~ \par
\~ \~ \~ \~ \~Console.WriteLine("Ano invalido");\par
\~ \~ \~ \~ \~Console.ReadLine(); \par
\~ \~ \~ \~ \~\}\par
\~ \~ \~ \~ \~\}\par
\~ \~ \~ \~ \~while(carro[x].anoveiculo > 2022);\par
\~ \~ \~ \~ \~Console.WriteLine("Cor do \{0\}\'ba Veiculo", x + 1);\par
\~ \~ \~ \~ \~carro[x].corveiculo = Console.ReadLine();\par
\~ \~ \~ \~ \~Console.Clear();\par
\~ \~ \~ \~\}\par
\~ \~ for (int x = 0; x < 5; x++)\par
\{\par
\~ \~ \~Console.WriteLine("Nome do \{0\}\'ba veiculo: \{1\}", x+1, carro[x].nmveiculo);\par
\~ \~ \~ \~Console.WriteLine("Ano do \{0\}\'ba veiculo: \{1\}", x+1, carro[x].anoveiculo);\par
\~ \~ \~ \~Console.WriteLine("Cor do \{0\}\'ba veiculo: \{1\}", x+1, carro[x].corveiculo);\par
\~ \~ \~ \~Console.ReadLine();\par
\~ \~\}\par
        Console.Clear();\par
        Console.WriteLine("Deseja excluir algum veiculo da lista?");\par
        Console.WriteLine("1 = yes/ 2 = no");\par
        A = int .Parse(Console.ReadLine());\par
        if(A == 1)\{\par
          Console.WriteLine("");\par
            Console.WriteLine("");\par
          Console.WriteLine("Qual carro deseja remover?");\par
          Console.WriteLine("");\par
          for (int x = 0; x < 5; x++)\par
\{\par
          \par
\~ \~ \~Console.WriteLine("Nome do \{0\}\'ba veiculo: \{1\}", x+1, carro[x].nmveiculo);\par
            Console.WriteLine("");\par
\~ \~ \~ \~Console.WriteLine("Ano do \{0\}\'ba veiculo: \{1\}", x+1, carro[x].anoveiculo);\par
            Console.WriteLine("");\par
\~ \~ \~ \~Console.WriteLine("Cor do \{0\}\'ba veiculo: \{1\}", x+1, carro[x].corveiculo);\par
            Console.WriteLine("");\par
            Console.WriteLine("Para remover o \{0\}\'ba veiculo digite: \{0\}", x+1);\par
            Console.WriteLine("");\par
            \par
\~ \~ \~ \~\par
          \}\par
        \par
          \}\par
        else\{\par
            Console.ReadLine();\par
        \}\par
\~ \~ \par
\~ \~ \~\}\par
\~ \~ \~ \~\}\par
\~ \~ \~ \}\par
\~ \~\par
}
 