using System;
using MORENAISBACK;

namespace TESTEMORENA
{
    public class Program
    {
        static MORENA _morena = new MORENA();

        public Program()
        {
            _morena = new MORENA();
        }

        static void Main(string[] args)
        {


            string nomeTabela = "batatinha";
            foreach (string item in _morena.Select(nomeTabela))
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();

        }
    }
}
