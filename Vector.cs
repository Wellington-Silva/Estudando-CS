using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendendo_CS {
     class Vector {
        public void Rodar() {
            string[] vetor = {
                "Telefonou para a vítima? (S/N): ",
                "Esteve no local do crime? (S/N): ",
                "Esteve no local do crime? (S/N): ",
                "Mora perto da vítima? (S/N): ",
                "Devia para a vítima? (S/N): ",
                "Já trabalhou com a vítima? (S/N): "
            };
            int contSim = 0;

            Console.WriteLine("-------------------------------");

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i] + " ");
                string resp = Console.ReadLine();
                if (resp.Equals("S"))
                {
                    contSim++;
                }
            }

            if (contSim == 2)
            {
                Console.WriteLine("Suspeita");
            }
            else if (contSim == 3 && contSim == 4)
            {
                Console.WriteLine("Cúmplice");
            }
            else if (contSim >= 5)
            {
                Console.WriteLine("Assassino");
            }
            else
            {
                Console.WriteLine("Inocente");
            }
            Console.WriteLine(contSim);
        }
    }
}
