using System.Collections.Generic;

public class Biblioteca
{
    public static Dictionary<int, Disco> discos { get; private set; } = InicializarBiblioteca();

    public static Dictionary<int, Disco> InicializarBiblioteca()
    {
        Dictionary<int, Disco> biblioteca = new Dictionary<int, Disco>();

        // Disco 1 - Oktubre (Los Redondos)
        List<string> canciones1 = new List<string> { "Fuegos de octubre", "Preso en mi ciudad", "Motor psico", "Jijiji", "Canción para naufragios" };
        DatoDisco datosDisco1 = new DatoDisco("Oktubre", "Segundo álbum de Los Redondos, con un sonido más político y oscuro.", "/img/oktubre.jpg", 850000, canciones1, "Carlos Alomar", "Patricio Rey y sus Redonditos de Ricota");
        Disco disco1 = new Disco(datosDisco1, canciones1);
        biblioteca.Add(1, disco1);

        // Disco 2 - Signos (Soda Stereo)
        List<string> canciones2 = new List<string> { "Signos", "Prófugos", "Persiana americana", "El rito", "Final caja negra" };
        DatoDisco datosDisco2 = new DatoDisco("Signos", "Tercer disco de Soda Stereo, una obra clave del rock en español.", "/img/signos.jpg",1500000, canciones2, "Charly Alberti", "Soda Stereo");
        Disco disco2 = new Disco(datosDisco2, canciones2);
        biblioteca.Add(2, disco2);

        // Disco 3 - El amor después del amor (Fito Páez)
        List<string> canciones3 = new List<string> { "El amor después del amor", "Dos días en la vida", "Tumbas de la gloria", "La rueda mágica", "Brillante sobre el mic" };
        DatoDisco datosDisco3 = new DatoDisco("El amor después del amor", "Uno de los discos más vendidos del rock argentino.", "/img/eada.jpg",2200000, canciones3, "Fito Páez", "Fito Páez");
        Disco disco3 = new Disco(datosDisco3, canciones3);
        biblioteca.Add(3, disco3);

        // Disco 4 - Peperina (Serú Girán)
        List<string> canciones4 = new List<string> { "Peperina", "Esperando nacer", "José Mercado", "Cinema verité", "Salir de la melancolía" };
        DatoDisco datosDisco4 = new DatoDisco("Peperina", "Último disco de estudio de Serú Girán, con letras más directas.", "/img/peperina.jpg",730000, canciones4, "Charly García", "Serú Girán");
        Disco disco4 = new Disco(datosDisco4, canciones4);
        biblioteca.Add(4, disco4);

        // Disco 5 - Azul (Los Piojos)
        List<string> canciones5 = new List<string> { "Maradó", "Verano del '92", "El balneario de los doctores crotos", "Ay ay ay", "Media caña" };
        DatoDisco datosDisco5 = new DatoDisco("Azul", "Uno de los discos más populares de Los Piojos, con sonidos más latinos.", "/img/azul.jpg",680000, canciones5, "Gustavo Lamas", "Los Piojos");
        Disco disco5 = new Disco(datosDisco5, canciones5);
        biblioteca.Add(5, disco5);

        return biblioteca;
    }
}
