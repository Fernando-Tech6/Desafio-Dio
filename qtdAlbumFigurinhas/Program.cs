using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qtdAlbumFigurinhas
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
                int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
                int totalDeFigurinhas = numeroDeFigurinhas;

                int[] albumDeFigurinha = new int[numeroDeFigurinhasCompradas];

            
            for (int i = 0; i < numeroDeFigurinhasCompradas; i++)
            {
             
                int numeroSerie = int.Parse(Console.ReadLine());

                if (!albumDeFigurinha.Contains(numeroSerie))
                {

                    albumDeFigurinha[i] = numeroSerie;

                    numeroDeFigurinhas -= 1;
                }
                if(numeroDeFigurinhas == 0)
                {
                    break;
                }

            }

            totalDeFigurinhas = numeroDeFigurinhas;
            Console.WriteLine(totalDeFigurinhas);
            Console.ReadLine();

        }

    }
}
    

