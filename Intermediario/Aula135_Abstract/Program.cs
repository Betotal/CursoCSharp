using System;
using System.Collections.Generic;
using Aula135_Abstract.Entities;
using Aula135_Abstract.Entities.Emums;

namespace Aula135_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre com a quantidade de figuras: ");
            int N = int.Parse(Console.ReadLine());

            List<Figura> Lista = new List<Figura>();
 
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Qual o tipo da figura {i} (");
                foreach (TipoFigura f in Enum.GetValues(typeof(TipoFigura)))
                {
                    Console.Write(f.ToString() + "/");
                    
                }
                Console.Write("): ");  
                TipoFigura tipoF = Enum.Parse<TipoFigura>(Console.ReadLine());

                Console.Write($"Qual a cor da figura (");
                foreach (Cor c in Enum.GetValues(typeof(Cor)))
                {
                    Console.Write(c.ToString() + "/");
                }
                Console.Write("): ");
                Cor tipoc = Enum.Parse<Cor>(Console.ReadLine());

                switch (tipoF)
                {
                    case TipoFigura.Circulo:
                        Console.Write("Informe o raio do circulo: ");
                        double raio = double.Parse(Console.ReadLine());
                        Lista.Add(new Circulo(raio, tipoc, tipoF)); 
                        break;
                    case TipoFigura.Triangulo:
                        Console.Write("Informe a Altura do triangulo retangulo: ");
                        double altura = double.Parse(Console.ReadLine());
                        Console.Write("Informe a Largura da Base triangulo: ");
                        double largura = double.Parse(Console.ReadLine());
                        Lista.Add(new Triangulo(largura, altura, tipoc, tipoF));
                        break;
                    case TipoFigura.Retangulo:
                        Console.Write("Informe a Altura do Retangulo: ");
                        altura = double.Parse(Console.ReadLine());
                        Console.Write("Informe a Largura da Retangulo: ");
                        largura = double.Parse(Console.ReadLine());
                        Lista.Add(new Retangulo(largura, altura, tipoc, tipoF));
                        break;
                    case TipoFigura.Quadrado:
                        Console.Write("Informe a medida do Quadrado: ");
                        largura = double.Parse(Console.ReadLine());
                        Lista.Add(new Retangulo (largura, largura, tipoc, tipoF));
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
            }
            foreach (Figura f in Lista)
            {
                Console.WriteLine("Figura: "
                                 + f.TipoF.ToString()
                                 + " - Area: "
                                 + f.Area().ToString("F2"));   
            }
        }
    }
}
