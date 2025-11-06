namespace Ejercicio1_Models;

public class Paquete
{
    public int NumeroRegistro {  get; set; }
    public double Peso {  get; set; }
    public string ZonaDestino { get; set; }
    public Paquete(int numeroRegistro, double peso, string zona)
    {
        this.NumeroRegistro = numeroRegistro;
        this.Peso = peso;
        this.ZonaDestino = zona;
    }
    public override string ToString()
    {
        return $"{NumeroRegistro};{Peso:f2}";
    }
}
