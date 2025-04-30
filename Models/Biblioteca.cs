using System.Collections.Generic;

public class Biblioteca
{
    public static Dictionary<int, Disco> discos { get; private set; } = InicializarBiblioteca();

    public static Dictionary<int, Disco> InicializarBiblioteca()
    {
        Dictionary<int, Disco> biblioteca = new Dictionary<int, Disco>();

        List<string> canciones1 = new List<string> { "Fuegos de octubre (3:58)", "Preso en mi ciudad (4:35)", "Motor psico (3:47)", "Jijiji (5:23)", "Canción para naufragios (4:05)" };
        DatoDisco datosDisco1 = new DatoDisco("Oktubre", "Segundo álbum de Los Redondos, con un sonido más político y oscuro.", "/img/oktubre.jpg", 850000, canciones1, "Carlos Alomar", "Patricio Rey y sus Redonditos de Ricota", "https://www.youtube.com/watch?v=9mkPiqN-NGo&list=PLWVo2tank-zzW1C3bCRwBF9JGOMxHcroD","https://www.youtube.com/@PatricioReyYSusRedonditos");
        Disco disco1 = new Disco(datosDisco1, canciones1);
        biblioteca.Add(1, disco1);

        // Disco 2 - Signos (Soda Stereo)
        List<string> canciones2 = new List<string> { "Signos (5:14)", "Prófugos (4:51)", "Persiana americana (4:55)", "El rito (3:42)", "Final caja negra (4:20)" };
        DatoDisco datosDisco2 = new DatoDisco("Signos", "Tercer disco de Soda Stereo, una obra clave del rock en español.", "/img/signos.jpg", 1500000, canciones2, "Charly Alberti", "Soda Stereo", "https://www.youtube.com/watch?v=mekT98tj6qU&list=PLbSeCbWwfEy842SPk9XWid7y5_dPRnX5r","https://www.youtube.com/channel/UC_MAancGcA0YeACrpSwokhQ");
        Disco disco2 = new Disco(datosDisco2, canciones2);
        biblioteca.Add(2, disco2);

        // Disco 3 - El amor después del amor (Fito Páez)
        List<string> canciones3 = new List<string> { "El amor después del amor (4:33)", "Dos días en la vida (4:20)", "Tumbas de la gloria (4:45)", "La rueda mágica (3:55)", "Brillante sobre el mic (4:10)" };
        DatoDisco datosDisco3 = new DatoDisco("El amor después del amor", "Uno de los discos más vendidos del rock argentino.", "/img/eada.jpg", 2200000, canciones3, "Fito Páez", "Fito Páez", "https://www.youtube.com/watch?v=wFCpNO0o638&list=PLWVo2tank-zyaSH_OgEdSKAc8TIoYjLbK","https://www.youtube.com/@FitoPaezOficial");
        Disco disco3 = new Disco(datosDisco3, canciones3);
        biblioteca.Add(3, disco3);

        // Disco 4 - Peperina (Serú Girán)
        List<string> canciones4 = new List<string> { "Peperina (4:52)", "Esperando nacer (3:49)", "José Mercado (4:03)", "Cinema verité (3:58)", "Salir de la melancolía (4:11)" };
        DatoDisco datosDisco4 = new DatoDisco("Peperina", "Último disco de estudio de Serú Girán, con letras más directas.", "/img/peperina.jpg", 730000, canciones4, "Charly García", "Serú Girán", "https://www.youtube.com/watch?v=H9l6hlKO3lI&list=PLWVo2tank-zz7CqnNRhQ-NSsbM0KmG10R","https://www.youtube.com/channel/UCd7HjSpY5Vgpcwhrw1cHxSg");
        Disco disco4 = new Disco(datosDisco4, canciones4);
        biblioteca.Add(4, disco4);

        // Disco 5 - Azul (Los Piojos)
        List<string> canciones5 = new List<string> { "Maradó (4:31)", "Verano del '92 (3:59)", "El balneario de los doctores crotos (4:26)", "Ay ay ay (3:44)", "Media caña (4:10)" };
        DatoDisco datosDisco5 = new DatoDisco("Azul", "Uno de los discos más populares de Los Piojos, con sonidos más latinos.", "/img/azul.jpg", 680000, canciones5, "Gustavo Lamas", "Los Piojos", "https://www.youtube.com/watch?v=nl1l3lQWHTs&list=PLSzpfFVdqaWIjEZsPuwFX0dauk1DmwHHZ","https://www.youtube.com/channel/UCnSnDYos8UDuKTvfwoD6KSw");
        Disco disco5 = new Disco(datosDisco5, canciones5);
        biblioteca.Add(5, disco5);

        // Disco 6 - The College Dropout (Kanye West)
        List<string> canciones6 = new List<string> { "We Don't Care (3:59)", "Through the Wire (3:41)", "Slow Jamz (5:16)", "All Falls Down (3:43)", "Jesus Walks (3:13)" };
        DatoDisco datosDisco6 = new DatoDisco("The College Dropout", "El debut de Kanye West, un álbum que fusionó el rap con otros géneros y tocó temas de la vida universitaria y la cultura.", "/img/thecollegedropout.jpg", 1000000, canciones6, "Kanye West", "Kanye West", "https://www.youtube.com/watch?v=OTZzjAU0Kg0&list=PLeO-rHNGADqzCkDOyEUZbJMnuu5s9yIGh","https://www.youtube.com/@kanyewest");
        Disco disco6 = new Disco(datosDisco6, canciones6);
        biblioteca.Add(6, disco6);

        // Disco 7 - Late Registration (Kanye West)
        List<string> canciones7 = new List<string> { "Heard 'Em Say (3:23)", "Touch the Sky (3:56)", "Gold Digger (3:27)", "Diamonds from Sierra Leone (3:59)", "Drive Slow (4:32)" };
        DatoDisco datosDisco7 = new DatoDisco("Late Registration", "El segundo álbum de Kanye, con una mezcla de rap clásico y nuevas influencias musicales, colaboraciones notables y una producción impresionante.", "/img/lateregistration.jpg", 1500000, canciones7, "Kanye West", "Kanye West", "https://www.youtube.com/watch?v=Bwyu-SZ7g_E&list=PLKZWLu6q09LNgUZoCSiT5yU2JkCwBjmMw","https://www.youtube.com/@kanyewest");
        Disco disco7 = new Disco(datosDisco7, canciones7);
        biblioteca.Add(7, disco7);

        // Disco 8 - Graduation (Kanye West)
        List<string> canciones8 = new List<string> { "Good Morning (3:15)", "Stronger (5:12)", "I Wonder (4:03)", "Flashing Lights (3:58)", "Homecoming (3:24)" };
        DatoDisco datosDisco8 = new DatoDisco("Graduation", "Un álbum de transición para Kanye West, que marcó el paso del rap tradicional a una sonoridad más electrónica y experimental.", "/img/graduation.jpg", 1800000, canciones8, "Kanye West", "Kanye West", "https://www.youtube.com/watch?v=WwYbTxOZF0k&list=PLAUxsgLNM2BuOcW0Bpp-nGT1oyrbfC7b1","https://www.youtube.com/@kanyewest");
        Disco disco8 = new Disco(datosDisco8, canciones8);
        biblioteca.Add(8, disco8);

        // Disco 9 - 808s & Heartbreak (Kanye West)
        List<string> canciones9 = new List<string> { "Say You Will (6:18)", "Heartless (3:31)", "Love Lockdown (4:30)", "Paranoid (4:37)", "Robocop (4:34)" };
        DatoDisco datosDisco9 = new DatoDisco("808s & Heartbreak", "Un giro radical en el estilo de Kanye, con un enfoque melódico y el uso del autotune, influenciado por la tristeza y el desamor.", "/img/808.png", 2000000, canciones9, "Kanye West", "Kanye West", "https://www.youtube.com/watch?v=d9BMPmfxaoM&list=PLX68ZEYlh74tpCb5sOXP98ito6DhP60-t","https://www.youtube.com/@kanyewest");
        Disco disco9 = new Disco(datosDisco9, canciones9);
        biblioteca.Add(9, disco9);

        // Disco 10 - My Beautiful Dark Twisted Fantasy (Kanye West)
        List<string> canciones10 = new List<string> { "Dark Fantasy (4:41)", "Power (3:41)", "All of the Lights (4:59)", "Monster (6:18)", "Runaway (9:08)" };
        DatoDisco datosDisco10 = new DatoDisco("My Beautiful Dark Twisted Fantasy", "Un álbum considerado por muchos como su obra maestra, con una producción grandiosa, colaboraciones épicas y una visión única.", "/img/mbdtf.jpg", 2500000, canciones10, "Kanye West", "Kanye West", "https://www.youtube.com/watch?v=UTH1VNHLjng&list=PL8YH4mOwWryUMna911yJM2B52iIIzigKy","https://www.youtube.com/@kanyewest");
        Disco disco10 = new Disco(datosDisco10, canciones10);
        biblioteca.Add(10, disco10);


        // Disco 11 - Yeezus (Kanye West)
        List<string> canciones11 = new List<string> { "On Sight (2:37)", "Black Skinhead (3:08)", "New Slang (3:10)", "Bound 2 (3:49)", "Blood on the Leaves (6:00)" };
        DatoDisco datosDisco11 = new DatoDisco("Yeezus", "Un álbum que rompió con las normas, lleno de minimalismo, experimentación y una visión audaz de Kanye sobre la música y la cultura.", "/img/yeezus.png", 2200000, canciones11, "Kanye West", "Kanye West", "https://www.youtube.com/watch?v=uU9Fe-WXew4&list=OLAK5uy_m6VFZd8KNhbFoHGRhtzFakGNVSkMMGvbU","https://www.youtube.com/@kanyewest");
        Disco disco11 = new Disco(datosDisco11, canciones11);
        biblioteca.Add(11, disco11);

        // Disco 12 - The Life of Pablo (Kanye West)
        List<string> canciones12 = new List<string> { "Ultralight Beam (5:20)", "Father Stretch My Hands Pt. 1 (2:15)", "Famous (3:16)", "Waves (3:01)", "Fade (3:13)" };
        DatoDisco datosDisco12 = new DatoDisco("The Life of Pablo", "Un álbum que mezcla géneros y sonidos de manera impredecible, con una visión cruda y personal de Kanye sobre la vida y la fama.", "/img/tlop.jpg", 2300000, canciones12, "Kanye West", "Kanye West", "https://www.youtube.com/watch?v=6oHdAA3AqnE&list=RDQMb7oPdevbzkQ&start_radio=1","https://www.youtube.com/@kanyewest");
        Disco disco12 = new Disco(datosDisco12, canciones12);
        biblioteca.Add(12, disco12);

        // Disco 13 - Jesus Is King (Kanye West)
        List<string> canciones13 = new List<string> { "Selah (2:44)", "Follow God (1:44)", "Closed on Sunday (2:31)", "Everything We Need (1:57)", "Jesus Is Lord (0:49)" };
        DatoDisco datosDisco13 = new DatoDisco("Jesus Is King", "Un álbum centrado en la espiritualidad y la fe, Kanye explora su relación con Dios y su conversión al cristianismo.", "/img/jesusisking.png", 1800000, canciones13, "Kanye West", "Kanye West", "https://www.youtube.com/watch?v=T58tRXzjC7c&list=PL5Z-QTr_hR1gTIk7T-bPCmRaaXNmiP3aK","https://www.youtube.com/@kanyewest");
        Disco disco13 = new Disco(datosDisco13, canciones13);
        biblioteca.Add(13, disco13);

        return biblioteca;
    }
}
