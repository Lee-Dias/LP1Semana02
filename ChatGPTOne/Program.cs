using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis
            string question, response;

            // pergunta ao utilizador
            Console.Write("Place your question? ");
            question = Console.ReadLine();

            // Respostas as perguntas
            switch (question)
            {
                case "EXIT":
                    response = "";
                    break;
                case "Who are you?":
                    response = "I'am God";
                    break;
                default:
                    response = "I'am sorry but that question i can't answer";
                    break;
            }

            // Responder adequadamente
            Console.WriteLine(response);
        }
    }
}
