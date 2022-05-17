using csharp_oop_shop;
using System;

namespace csharp_es03_mattina // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine(random.Next(0, 10));


            try
            {

                Prodotto prod1 = new Prodotto("pasta barilla", "pasta da fare al sugo", 1.69, 22);


                Console.WriteLine("Codice: {0}", prod1.Codice);
                Console.WriteLine("Nome: {0}", prod1.Nome);
                Console.WriteLine("Descrizione: {0}", prod1.Descrizione);
                Console.WriteLine(prod1.prezzoIvato());
                Console.WriteLine(prod1.codicePiuNome());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}