
using System.Data;

namespace Ejercicio1_Models;

public class Camion
{
    double pesoControl = 0;
    public int patente { get; set; }
    public double PesoMax { get; set; }
    Stack<Paquete> paquetes = new Stack<Paquete>();
    public Camion(int patente, double peso)
    {
        this.PesoMax = peso;
        this.patente = patente;
    }
    public string[] VerCarga()
    {
        string[] ret = new string[paquetes.Count];
        int n = 0;
        foreach (Paquete pa in paquetes)
        { ret[n++] = pa.ToString(); }
        return ret;
    }

    public bool AgregarPaquete(Paquete unPaquete)
    {
        if (unPaquete == null)
        { throw new Exception("Paquete Nulo"); }
        if (unPaquete.Peso + CargaEnKg() <= PesoMax)
        {
            paquetes.Push(unPaquete);
            return true;
        }
        return false;
    }
    internal double CargaEnKg()
    {
        pesoControl = 0;
        foreach (Paquete pa in paquetes)
        {
            pesoControl += pa.Peso;
        }
        return pesoControl;
    }

    public Paquete QuitarPaquete()
    {
        if(paquetes.Count > 0)
        {
            return paquetes.Pop();
        }
        return null;
    }
}
