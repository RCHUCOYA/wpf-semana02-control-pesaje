namespace WPF_SEMANA02.Models;

public class Ingreso
{
    public DateTime Fecha { get; set; }
    public string TipoDocumento { get; set; } = string.Empty;
    public string NumeroDocumento { get; set; } = string.Empty;
    public string Placa { get; set; } = string.Empty;
    public double Peso { get; set; }
    public string TipoVehiculo { get; set; } = string.Empty;
    public string Transportista { get; set; } = string.Empty;
    public string Producto { get; set; } = string.Empty;
    public string Observacion { get; set; } = string.Empty;
}
