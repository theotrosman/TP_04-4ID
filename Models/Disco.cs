public class Disco
{
    public DatoDisco Datos { get; private set; }
    public List<string> Canciones { get; private set; }

    public Disco(DatoDisco datos, List<string> canciones)
    {
        this.Datos = datos;
        this.Canciones = canciones;
    }
}
