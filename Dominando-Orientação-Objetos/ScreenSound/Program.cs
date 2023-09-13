using ScreenSound.Menus;
using ScreenSound.Modelos;
using OpenAI_API;



        

        Banda ira = new Banda("ira");
        ira.AdicionarNota(new Avaliacao(10));
        ira.AdicionarNota(new Avaliacao(10));
        ira.AdicionarNota(new Avaliacao(10));
        ira.AdicionarNota(new Avaliacao(10));
        Banda beatles = new("the beatles");
        beatles.AdicionarNota(new Avaliacao(12));
        beatles.AdicionarNota(new Avaliacao(1));
        beatles.AdicionarNota(new Avaliacao(13));
        beatles.AdicionarNota(new Avaliacao(20));

        Dictionary<string, Banda> bandasRegistradas = new Dictionary<string, Banda>();
        bandasRegistradas.Add(ira.Nome, ira);
        bandasRegistradas.Add(beatles.Nome, beatles);

        Dictionary<int, Menu> opcoes = new();
        opcoes.Add(1, new RegistrarBanda());
        opcoes.Add(2, new RegistrarAlbum());
        opcoes.Add(3, new MonstrarBandasRgistradas());
        opcoes.Add(4, new AvaliarBanda ());
        opcoes.Add(5, new MenuExibirDetalhes());
        opcoes.Add(6, new AvaliarAlbum());
        opcoes.Add(-1, new MenuSair());


        void ExibirLogo()
        {
            Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
            Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
        }

        void ExibirOpcoesDoMenu()
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para mostrar todas as bandas");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
            Console.WriteLine("Digite 6 para dar nota aos albuns");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
            if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
            {
                Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
                menuASerExibido.Executar(bandasRegistradas);
                if (opcaoEscolhidaNumerica > 0)
                {
                    ExibirOpcoesDoMenu();
                }
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }
        ExibirOpcoesDoMenu();
    