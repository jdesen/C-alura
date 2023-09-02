/*
 Desafio:criar as classes popdcast e o episodio 
 */



class Podcast{

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    private List<Episodio> TotalDeEpisodios = new List<Episodio>();
    //Metodos

    public void AdicionarEpisodio(Episodio item) {
        TotalDeEpisodios.Add(item);
    }

    public void ExibirDetalher()
    {
        Console.WriteLine($" Podcast: {Nome}");
        Console.WriteLine($" host :{Host}");
        foreach (var item in TotalDeEpisodios)
        {
            Console.WriteLine($" episodio: {item.Titulo}");
        }
    }

}

class Episodio{
    public int Duracao { get; }

    public Episodio(int duracao, string resumo, string titulo)
    {
        Duracao = duracao;
        Resumo = resumo;
        Titulo = titulo;
    }

    public string Resumo { get; }

    public List<string> Ordem = new List<string>();

    public string Titulo { get; }
    //metodos
    public void AdicionarConvidao(string conv)
    {
        Ordem.Add(conv);
    }

}