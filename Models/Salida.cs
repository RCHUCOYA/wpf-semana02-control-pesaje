namespace WPF_SEMANA02.Models;
public class Salida
{
    public string TipoDocumento { get; set; } = "";
    public string NumeroDocumento { get; set; } = "";
    public double Peso { get; set; }
    public string TipoAuto { get; set; } = "";
    public string NombreTransportista { get; set; } = "";
    public DateTime FechaYHora { get; set; }
    public double PesoIngreso { get; set; }
    public double PesoSalida { get; set; }
    public DateTime Fecha => FechaYHora.Date;
}
