using System.Runtime.CompilerServices;

namespace Ejercicio1_Models;

public class Sistema
{
    public List<Paquete> ListaPaquetes = new List<Paquete>();
    List<Camion> ListaCamiones = new List<Camion>();
    public Sistema()
    {
        ListaCamiones.Add(new Camion(100, 1000));
        ListaCamiones.Add(new Camion(101, 1000));
        ListaCamiones.Add(new Camion(102, 1000));
    }
    public void Descargar(Stream fs)
    {
        StreamReader sr = new StreamReader(fs);
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            string[] datos = line.Split(";");

            int id = Convert.ToInt32(datos[0]);
            double peso = Convert.ToDouble(datos[1]);
            string zona = datos[2];

            Paquete P = new Paquete(id, peso, zona);
            ListaPaquetes.Add(P);
        }
    }
    public string[] CamionesCargados()
    {
        string[] cs = new string[ListaCamiones.Count];

        int i = 0;
        foreach (Camion c in ListaCamiones)
        {
            cs[i++] = $"{c.patente.ToString()}({c.PesoMax})";
        }
        return cs;
    }
    public string[] VerCargaCamion(int pos)
    {
        Camion c = ListaCamiones[pos];
        return c.VerCarga();
    }
    public double CargarPaquete(int pos, Paquete unPaquete)
    {
        Camion c = ListaCamiones[pos];

        if (c.AgregarPaquete(unPaquete) == true)
        {
            ListaPaquetes.Remove(unPaquete);
        }
        return c.CargaEnKg();
    }

    public double RetirarPaquete(int pos)
    {
        Camion c = ListaCamiones[pos];
        Paquete retirado = c.QuitarPaquete();
        if (retirado != null)
        {
            ListaPaquetes.Add(retirado);
        }
        return c.CargaEnKg();
    }

    public void RetirarCamion(FileStream fs, int pos)
    {
        StreamWriter sw = new StreamWriter(fs);
        Camion c = ListaCamiones[pos];
        foreach (string p in c.VerCarga())
        {
            sw.WriteLine(p);
        }
        sw.Close();
    }
}
