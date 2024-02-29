using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis
            string question, response;
            bool exit = true;

            // pergunta ao utilizador
            while (exit == true){
                Console.Write("Place your question? ");
                question = Console.ReadLine();

                // Respostas as perguntas
                switch (question)
                {
                    case "EXIT":
                        response = "";
                        exit = false;
                        break;
                    case "Who are you?":
                        response = "I'am God!";
                        break;
                    case "How can i be better in school?":
                        response = "Be more attentive to class and study!";
                        break;
                    case "Where do u live?":
                        response = "I don't live in one place I am everywhere!";
                        break;
                    case "How can i be intelligent like you?":
                        response = "U can't because I know everything!";
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
}
