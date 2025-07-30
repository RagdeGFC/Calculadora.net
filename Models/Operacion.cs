namespace src.Models
{
  public class Operacion
  {
    public double Numero1 { get; set; }
    public double Numero2 { get; set; }
    public string Operador { get; set; } = "+"; // Esto evita el error de null
    public double Resultado { get; set; }
  }
}
