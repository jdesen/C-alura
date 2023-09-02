class Album
{
    public Album(String nome)
    {
        Nome = nome;
    }
    private List<Musica> lista = new List<Musica>();
    public string Nome { get; set; }

    public int DuracaoTotal => Lista.Sum(m =>m.Duracao);

    internal List<Musica> Lista { get => lista; set => lista = value; }

    public void AdcionarMusica(Musica musical)
    {
        this.Lista.Add(musical);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine("Lista de musicas do album "+ this.Nome);
        foreach (var item in Lista)
        {
            Console.WriteLine($" Musica :{item.Nome}");
        }
        Console.WriteLine($"Para ouvir esse album você precisa de {DuracaoTotal}");
        
    }
}