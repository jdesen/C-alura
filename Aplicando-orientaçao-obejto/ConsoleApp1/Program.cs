Banda queen = new Banda("Quenn");

Album albumDoQuin = new Album("a night at the opera");
Musica musical = new Musica(queen, "Love of my live ");
musical.Duracao= 213;
Musica musical2  = new Musica(queen, "Bohemian Rhapsody");
musical2.Duracao = 300;

albumDoQuin.AdcionarMusica(musical);
albumDoQuin.AdcionarMusica(musical2);

queen.AdicionarAlbum(albumDoQuin);
/*queen.Exibir(); */

Podcast JovemNerd = new Podcast("jovem","Nerd");
Episodio j54 = new Episodio(1000,"muito bom","rpg de aventura a volta do deus caido");
JovemNerd.AdicionarEpisodio(j54);
JovemNerd.ExibirDetalher();