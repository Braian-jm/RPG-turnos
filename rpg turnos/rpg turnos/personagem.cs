using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_turnos
{
    class personagem
    {
        string nome;
        string classe;
        int pv;
        int pe;

        public void criar_personagem()
        {
            Console.WriteLine("Nome do personagem: ?");
            nome = Console.ReadLine();
            Console.Clear(); 
            Console.WriteLine("CLASSES DISPONIVEIS");
            Console.WriteLine("");
            Console.WriteLine("1 - Guerreiro");
            Console.WriteLine("2 - Arqueiro");
            Console.WriteLine("3 - Mago");
            Console.WriteLine("4 - Monge");
            Console.WriteLine("");
            Console.WriteLine("Escreva a classe do seu personagem ");
            classe = Console.ReadLine(); 

            while(classe != "Guerreiro" && classe != "Arqueiro" && classe != "Mago" && classe != "Monge")
            {
                Console.WriteLine("CLASSE INVALIDA!");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("CLASSES DISPONIVEIS");
                Console.WriteLine("");
                Console.WriteLine("1 - Guerreiro");
                Console.WriteLine("2 - Arqueiro");
                Console.WriteLine("3 - Mago");
                Console.WriteLine("4 - Monge");
                Console.WriteLine("");
                Console.WriteLine("Escreva a classe do seu personagem ");
            }
        } 
    }
}
