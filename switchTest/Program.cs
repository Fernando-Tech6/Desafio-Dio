using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string grupo; //declare as suas variaveis
            string especie;
            string habitoAlimentar;

            grupo = Console.ReadLine(); //insira suas variaveis
            especie = Console.ReadLine();
            habitoAlimentar = Console.ReadLine();

            switch(grupo.ToLower())
            {
                case "vertebrado":
                    switch(especie.ToLower())
                    {
                        case "ave":
                            switch(habitoAlimentar.ToLower())
                            {
                                case "carnivoro":
                                    Console.WriteLine("aguia");
                                    break;

                                case "onivoro":
                                    Console.WriteLine("pomba");
                                    break;
                            }
                            break;

                        case "mamifero":
                            switch(habitoAlimentar.ToLower())
                            {
                                case "onivoro":
                                    Console.WriteLine("homem");
                                    break;

                                case "herbivoro":
                                    Console.WriteLine("vaca");
                                    break;
                            }
                            break;

                    }
                break;


                case "invertebrado":
                    switch (especie.ToLower())
                    {
                        case "inseto":
                            switch (habitoAlimentar.ToLower())
                            {
                                case "hematofago":
                                    Console.WriteLine("pulga");
                                    break;

                                case "herbivoro":
                                    Console.WriteLine("lagarta");
                                    break;
                            }
                            break;

                        case "anelideo":
                            switch (habitoAlimentar.ToLower())
                            {
                                case "hematofago":
                                    Console.WriteLine("sanguessuga");
                                    break;

                                case "onivoro":
                                    Console.WriteLine("minhoca");
                                    break;
                            }
                            break;

                    }
                    break;

            }

            Console.ReadLine();

        }
    }
}
