using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chacal
{
    class Program
    {
        public struct People{
            public String name;
            public int age;
            public double height;
        }
        static void Main(string[] args)
        {
            People[] p = new People[500];
            int op = 0;
            int x = loadingData(p);

            do
            {
                op = menu();
                switch (op)
                {

                    case 1:
                        p[x] = entraceData();
                        register(p[x]);
                        x++;
                        break;
                    case 2:
                        Console.WriteLine("\n *** List *** ");
                        for (int i = 0; i < x; i++) showData(p[i]);
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("invalid opinion");
                        break;
                }
                pause();
            } while (op != 0);
        }
        static void c()
        {
            Console.Clear();
        }
        static int menu(){
            c();
            Console.WriteLine("1-Register data");
            Console.WriteLine("2-List data");
            Console.WriteLine("0-Exit");
            Console.WriteLine("\nEnter the desired option: ");
            return int.Parse(Console.ReadLine());
        }
        static void showData(People aux){
            Console.WriteLine("\n" + aux.name + "\t");
            Console.WriteLine(aux.age + "\t");
            Console.WriteLine(aux.height);
        }
        static People entraceData()
        {
            People aux;

            Console.Write("\nwrite a name: ");
            aux.name = Console.ReadLine();
            Console.Write("write an age: ");
            aux.age = int.Parse(Console.ReadLine());
            Console.Write("write a height: ");
            aux.height = double.Parse(Console.ReadLine());

            return aux;
        }
        static void pause(){
            Console.WriteLine("\n\nPressione alguma tecla para continuar!!");
            Console.ReadKey();
        }
        static void register(People aux)
        {
            FileStream streamRegister = new FileStream(@"C:\Users\aluno\desktop\chacal\chacal\Exemplo7.bin", FileMode.Append);
            BinaryWriter writer = new BinaryWriter(streamRegister);

            writer.Write(aux.name);
            writer.Write(aux.age);
            writer.Write(aux.height);
            writer.Flush();
            writer.Close();
        }
        static int loadingData(People[] p)
        {
            FileStream streamListar;

            if (!File.Exists(@"C:\Users\Aluno\Desktop\chacal\chacal\Exemplo7.bin")) {
                streamListar = new FileStream(@"C:\Users\Aluno\Desktop\chacal\chacal\Exemplo7.bin", FileMode.Create);
            }
            else
            {
                streamListar = new FileStream(@"C:\Users\Aluno\Desktop\chacal\chacal\Exemplo7.bin", FileMode.Open);
            }

            int cont = 0;

            BinaryReader reader = new BinaryReader(streamListar);

            while (reader.PeekChar() > -1)
            {
                p[cont].name = reader.ReadString();
                p[cont].age = reader.ReadInt32();
                p[cont].height = reader.ReadDouble();
                cont++;
            }
            reader.Close();
            return cont;
        }
    }
}
