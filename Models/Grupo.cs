namespace TP01.Models;
public class Grupo
{
  
    private Dictionary<int,Integrante> Integrantes;
   

    public Grupo ()
    {

        Integrantes= new Dictionary<int, Integrante>();
        CargaDatosManual();
        
    }
    public void CargaDatosManual()
    {
        List<string> FamiliaresTomu = new List <string> {"La maquina fernando (papa)", "Betiana(mama)", "Agustin(Hermano)"};
        List<string> FamiliaresPigu = new List <string> {"La maquina Mariano (papa)", "Yael(mama)", "Eitan(Hermano)", "Carmit(hermana)"};
        List<string> InteresesTomu = new List<string> {"Padel", "Peliculas", "Juegos"};
        List<string> InteresesPigu = new List<string> {"Futbol", "Series", "Ropa"};
        Integrante i2= new Integrante ("Tomas", 50324501, "/Imagenes/tomu.jpg", new DateTime(2010, 03, 06), FamiliaresTomu, InteresesTomu);
        Integrante i1= new Integrante("Igal", 49836363,"/Imagenes/pigu.jpg", new DateTime(2009,01,11), FamiliaresPigu, InteresesPigu);
        
        Integrantes.Add(i1.GetDNI(), i1);
        Integrantes.Add(i2.GetDNI(), i2);
    }
    public Dictionary<int, Integrante> DevolverIntegrantes()
    {
        return this.Integrantes;
    }
    public Integrante GetIntegrante(int dni)
    {
        if(Integrantes.ContainsKey(dni))
        {
            return Integrantes[dni];
        } 
        else 
        {
            return null;
        }
    }
   
}