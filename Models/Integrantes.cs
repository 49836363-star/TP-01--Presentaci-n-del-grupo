namespace TP01;
public class Integrantes
{
    private int DNI;
    private string foto;
    private datetime fecha;
    private string nombre;
    private List<string> Familiares;
    private List<string> Intereses;

    public Integrantes(int DNI, string foto, datetime fecha, string nombre, List<string> Familiares, List<string> Intereses)
    {
        this.DNI = DNI;
        this.foto = foto;
        this.fecha = fecha;
        this.nombre = nombre;
        this.Familiares = Familiares;
        this.Intereses = Intereses;
    }
}