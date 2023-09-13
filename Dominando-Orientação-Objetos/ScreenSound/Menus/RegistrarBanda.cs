using OpenAI_API;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class RegistrarBanda:Menu
    {
        public override void Executar (Dictionary<string, Banda> bandasRegistradas) 
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Registro das bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            bandasRegistradas.Add(nomeDaBanda, new Banda(nomeDaBanda));

            var client = new OpenAIAPI("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");

            var chat = client.Chat.CreateConversation();

            chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em 1 parágrafo");

            string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
            bandasRegistradas[nomeDaBanda].Resumo = resposta;
            

            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Console.WriteLine("Digite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
