namespace TP01.Models;
public class Integrante
{
    private string nombre;
    private int DNI;
    private string foto;
    private DateTime fecha;
    private List<string> Familiares;
    private List<string> Intereses;

    public Integrante(string nombre, int DNI, string foto, DateTime fecha, List<string> Familiares, List<string> Intereses)
    {
        this.nombre = nombre;
        this.DNI = DNI;
        this.foto = foto;
        this.fecha = fecha;
        this.Familiares = Familiares;
        this.Intereses = Intereses;
    }
    public string GetNombre()
    {
        return this.nombre;
    }
    public int GetDNI()
    {
        return this.DNI;
    }
    public string GetFoto()
    {
        return this.foto;
    }
    public DateTime GetFecha()
    {
        return this.fecha;
    }
    public List<string> GetFamiliares()
    {
        return this.Familiares;
    }
    public List<string> GetIntereses()
    {
        return this.Intereses;
    }
}   