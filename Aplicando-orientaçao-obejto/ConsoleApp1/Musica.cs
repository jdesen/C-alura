class Musica
{
    public Musica(Banda banda,
string nome)
    {

        Artista = banda;
        Nome = nome;
    }
    public string Nome { get; set; }
    public Banda Artista { get;}
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string NomeCompleto { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"nome {Nome}");
        Console.WriteLine($"artista {Artista}");
        Console.WriteLine($"duração {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("disponivel");
        }
        else
        {
            Console.WriteLine($"Nao disponivel");
        };
        
    }
}