namespace tp00;
public class Vehiculo
{
    private int numeroIdentificador;
    private double nivelBateria;
    private double contadorKM;
    private string tipoDeVehiculo;

    public Vehiculo (int numeroIdentificador, double nivelBateria, double contadorKM, string tipoDeVehiculo)
    {
        this.numeroIdentificador = numeroIdentificador;
        this.nivelBateria = nivelBateria;
        this.contadorKM = contadorKM;
        this.tipoDeVehiculo = tipoDeVehiculo;
    }

    public void RealizarViaje (double km)
    {
        bool HacerViaje = ValidarViaje();
        if (HacerViaje == true)
        {
            this.contadorKM+=km;
            if(this.tipoDeVehiculo=="bicicleta")
            {
                this.nivelBateria-= 0.8*km;
                
            }
            else
            {
                this.nivelBateria-= 1.5*km;

            }
            if(this.nivelBateria<0)
                {
                    this.nivelBateria=0;
                }
        }
        else
        {
            System.Console.WriteLine("El viaje no se pudo realizar");
        }
        
    }
    public void cargarBateria()
        {
            this.nivelBateria=100;
        }
    private bool ValidarViaje()
    {
        if (this.nivelBateria>20 && this.contadorKM<500)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    private int DevolverInt(string mensaje)
    {
        Console.WriteLine(mensaje);
        int valor = int.Parse(Console.ReadLine());
        return valor;
    }
    public string ObtenerTipoDeVehiculo ()
    {
        return this.tipoDeVehiculo;
    }
    public int obtenerNumeroIdentificador()
    {
        return this.numeroIdentificador;
    }
}