namespace WPF_SEMANA02.Models;

public class Salida
{
    public string TipoDocumento { get; set; } = string.Empty;
    public string NumeroDocumento { get; set; } = string.Empty;
    public double Peso { get; set; }
    public string TipoAuto { get; set; } = string.Empty;
    public string NombreTransportista { get; set; } = string.Empty;
    public DateTime FechaYHora { get; set; }
    public double PesoIngreso { get; set; }
    public double PesoSalida { get; set; }
    public DateTime Fecha => FechaYHora.Date;
}
