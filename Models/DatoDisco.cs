public class DatoDisco
{
    public string Nombre { get; private set; }
    public string Descripción { get; private set; }
    public int OyentesMensuales { get; private set; }
    public List<string> Canciones { get; private set; }
    public string Productor { get; private set; }
    public string Banda { get; private set; }

    public DatoDisco(string Nombre, string Descripción, int OyentesMensuales, List<string> Canciones, string Productor, string Banda)
    {
        this.Nombre = Nombre;
        this.Descripción = Descripción;
        this.OyentesMensuales = OyentesMensuales;
        this.Canciones = Canciones;
        this.Productor = Productor;
        this.Banda = Banda;
    }
}
