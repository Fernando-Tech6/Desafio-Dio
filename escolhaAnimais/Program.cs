using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escolhaAnimais
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, 
             * da esquerda para a direita.  Em seguida conclua qual dos animais seguintes foi escolhido, 
             * através das três palavras fornecidas.
             * 
             * A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima,
             * com todas as letras minúsculas
             */
            string grupo; //declare as suas variaveis
            string especie;
            string habitoAlimentar;

             grupo = Console.ReadLine(); //insira suas variaveis
             especie = Console.ReadLine();
             habitoAlimentar = Console.ReadLine();


            if (grupo.ToLower() == "vertebrado" && especie.ToLower() == "ave") 
            {
                if (habitoAlimentar.ToLower() == "carnivoro")
                {
                    Console.WriteLine("aguia");
                }

                if (habitoAlimentar.ToLower() == "onivoro")
                {
                    Console.WriteLine("pomba");
                }

            }

    
            if (grupo.ToLower() == "vertebrado" && especie.ToLower() == "mamifero")
            {
                if(habitoAlimentar.ToLower() == "onivoro")
                {
                    Console.WriteLine("homem");
                }

                if (habitoAlimentar.ToLower() == "herbivoro")
                {
                    Console.WriteLine("vaca");

                }

            }

            if (grupo.ToLower() == "invertebrado" && especie.ToLower() == "inseto")
            {
                if (habitoAlimentar.ToLower() == "hematofago")
                {
                    Console.WriteLine("pulga");
                }

                if (habitoAlimentar.ToLower() == "herbivoro")
                {
                    Console.WriteLine("lagarta");
                }
            }

       
            if (grupo.ToLower() == "invertebrado" && especie.ToLower() == "anelideo")
            {
                if (habitoAlimentar.ToLower() == "hematofago")
                {
                    Console.WriteLine("sanguessuga");
                }

                if(habitoAlimentar.ToLower() == "onivoro")
                {
                    Console.WriteLine("minhoca");
                }
            }

            Console.ReadLine();

        }
    }
}
