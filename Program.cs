using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagem;

            Console.WriteLine("Olá. Digite sua mensagem: ");
            mensagem = Console.ReadLine();

            mensagem = mensagem.Replace("rr", "l")
                               .Replace("RR", "L")
                               .Replace("rR", "l")
                               .Replace("Rr", "L")
                               .Replace("R", "L")
                               .Replace("r", "l");
            
            //mensagem = mensagem.Replace("R", "L");

            Console.WriteLine(mensagem);
        }
    }
}
