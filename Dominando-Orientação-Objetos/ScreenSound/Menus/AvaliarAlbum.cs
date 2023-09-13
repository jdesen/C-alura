﻿using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class AvaliarAlbum:Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Avaliar ");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.Write("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;
                Banda banda = bandasRegistradas[nomeDaBanda];
                if (banda.Albuns.Any (a =>a.Nome.Equals(tituloAlbum)))
                {
                    Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                    Console.Write($"Qual a nota que a album {tituloAlbum} merece: ");
                    Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                    album.AdicionarNota(nota);
                    Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para o album {tituloAlbum}");
                    Thread.Sleep(2000);
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine($"\n o album {tituloAlbum} não foi encontrada!");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();

                }


            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
