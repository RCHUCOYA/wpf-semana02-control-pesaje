namespace WPF_SEMANA02.Models;

public class Ingreso
{
    public DateTime Fecha { get; set; }
    public double Peso { get; set; }
    public string TipoVehiculo { get; set; } = string.Empty;
    public string Transportista { get; set; } = string.Empty;
}
