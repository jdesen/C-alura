using System.Diagnostics.Contracts;

class Banda

{
    public Banda(string nome)
    {
        Nome = nome;
    }
    private List<Album> albums= new List<Album>();
    public string Nome{ get; set; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }
    public void Exibir() {

        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (var item in albums)
        {
            Console.WriteLine($" Album: {item.Nome}({item.DuracaoTotal})");
        }
    }

}