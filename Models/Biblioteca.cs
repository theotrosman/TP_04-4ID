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
        DatoDisco datosDisco2 = new DatoDisco("Signos", "Tercer disco de Soda Stereo, una obra clave del rock en español.", "/img/signos.jpg", 1500000, canciones2, "Charly Alberti", "Soda Stereo");
        Disco disco2 = new Disco(datosDisco2, canciones2);
        biblioteca.Add(2, disco2);

        // Disco 3 - El amor después del amor (Fito Páez)
        List<string> canciones3 = new List<string> { "El amor después del amor", "Dos días en la vida", "Tumbas de la gloria", "La rueda mágica", "Brillante sobre el mic" };
        DatoDisco datosDisco3 = new DatoDisco("El amor después del amor", "Uno de los discos más vendidos del rock argentino.", "/img/eada.jpg", 2200000, canciones3, "Fito Páez", "Fito Páez");
        Disco disco3 = new Disco(datosDisco3, canciones3);
        biblioteca.Add(3, disco3);

        // Disco 4 - Peperina (Serú Girán)
        List<string> canciones4 = new List<string> { "Peperina", "Esperando nacer", "José Mercado", "Cinema verité", "Salir de la melancolía" };
        DatoDisco datosDisco4 = new DatoDisco("Peperina", "Último disco de estudio de Serú Girán, con letras más directas.", "/img/peperina.jpg", 730000, canciones4, "Charly García", "Serú Girán");
        Disco disco4 = new Disco(datosDisco4, canciones4);
        biblioteca.Add(4, disco4);

        // Disco 5 - Azul (Los Piojos)
        List<string> canciones5 = new List<string> { "Maradó", "Verano del '92", "El balneario de los doctores crotos", "Ay ay ay", "Media caña" };
        DatoDisco datosDisco5 = new DatoDisco("Azul", "Uno de los discos más populares de Los Piojos, con sonidos más latinos.", "/img/azul.jpg", 680000, canciones5, "Gustavo Lamas", "Los Piojos");
        Disco disco5 = new Disco(datosDisco5, canciones5);
        biblioteca.Add(5, disco5);
        // Disco 6 - El León (Los Auténticos Decadentes)
        List<string> canciones6 = new List<string> { "El León", "La cumbia de los trapos", "El amor después del amor", "Vení, vení", "Pánico" };
        DatoDisco datosDisco6 = new DatoDisco("El León", "Un disco emblemático de Los Auténticos Decadentes, fusionando cumbia, rock y ska.", "/img/elleon.jpg", 500000, canciones6, "Los Auténticos Decadentes", "Los Auténticos Decadentes");
        Disco disco6 = new Disco(datosDisco6, canciones6);
        biblioteca.Add(6, disco6);

        // Disco 7 - Doble Vida (Soda Stereo)
        List<string> canciones7 = new List<string> { "Te hacen falta vitaminas", "Un millón de años luz", "Prófugos", "En el borde", "Zoom" };
        DatoDisco datosDisco7 = new DatoDisco("Doble Vida", "Un disco clave en la carrera de Soda Stereo con un sonido más experimental y electrónico.", "/img/doblevida.jpg", 1300000, canciones7, "Charly Alberti", "Soda Stereo");
        Disco disco7 = new Disco(datosDisco7, canciones7);
        biblioteca.Add(7, disco7);

        // Disco 8 - Abraxas (Santana)
        List<string> canciones8 = new List<string> { "Black Magic Woman", "Oye Como Va", "Samba Pa Ti", "Incident at Neshabur", "El Nicoya" };
        DatoDisco datosDisco8 = new DatoDisco("Abraxas", "Un clásico del rock latino con una mezcla de jazz, blues y música latina.", "/img/abraxas.jpg", 2000000, canciones8, "Santana", "Santana");
        Disco disco8 = new Disco(datosDisco8, canciones8);
        biblioteca.Add(8, disco8);

        // Disco 9 - La Leyenda del Lejano Oeste (Los Pericos)
        List<string> canciones9 = new List<string> { "Pupilas Lejanas", "La noche", "Me late", "Todo el tiempo", "El hijo del viento" };
        DatoDisco datosDisco9 = new DatoDisco("La Leyenda del Lejano Oeste", "Uno de los discos más conocidos de Los Pericos, con sonidos reggae y ska.", "/img/laleyendadellejanoweste.jpg", 500000, canciones9, "Los Pericos", "Los Pericos");
        Disco disco9 = new Disco(datosDisco9, canciones9);
        biblioteca.Add(9, disco9);

        // Disco 10 - Charly García (Clics Modernos)
        List<string> canciones10 = new List<string> { "Clics modernos", "Nos siguen pegando abajo", "De música ligera", "Superman", "Mundo del amor" };
        DatoDisco datosDisco10 = new DatoDisco("Clics Modernos", "El disco que definió el estilo de Charly García como solista, con sonidos nuevos para la época.", "/img/clicsmodernos.jpg", 1200000, canciones10, "Charly García", "Charly García");
        Disco disco10 = new Disco(datosDisco10, canciones10);
        biblioteca.Add(10, disco10);

        // Disco 11 - La Casa del Pueblo (Fito Páez)
        List<string> canciones11 = new List<string> { "La Casa del Pueblo", "Nuestro amor", "Bajo el mar", "Lo que queda", "Lo primero de mí" };
        DatoDisco datosDisco11 = new DatoDisco("La Casa del Pueblo", "Un disco que mezcla rock, pop y tintes de música clásica, con una lírica emocional.", "/img/lacasadelpueblo.jpg", 900000, canciones11, "Fito Páez", "Fito Páez");
        Disco disco11 = new Disco(datosDisco11, canciones11);
        biblioteca.Add(11, disco11);

        // Disco 12 - A Tempered Heart (R.E.M.)
        List<string> canciones12 = new List<string> { "The One I Love", "What's the Frequency, Kenneth?", "Everybody Hurts", "Shiny Happy People", "Find the River" };
        DatoDisco datosDisco12 = new DatoDisco("A Tempered Heart", "Un disco aclamado por la crítica, con un estilo alternativo que caracterizó a la banda.", "/img/atemperedheart.jpg", 1500000, canciones12, "Michael Stipe", "R.E.M.");
        Disco disco12 = new Disco(datosDisco12, canciones12);
        biblioteca.Add(12, disco12);

        // Disco 13 - Me verás Volver (Luis Miguel)
        List<string> canciones13 = new List<string> { "La incondicional", "Frente a frente", "Me verás volver", "Sabes una cosa", "Solamente tú" };
        DatoDisco datosDisco13 = new DatoDisco("Me verás Volver", "El regreso de Luis Miguel después de una larga pausa, con un sonido de balada romántica.", "/img/meverasvolver.jpg", 1600000, canciones13, "Luis Miguel", "Luis Miguel");
        Disco disco13 = new Disco(datosDisco13, canciones13);
        biblioteca.Add(13, disco13);

        return biblioteca;
    }
}
