using System.Collections.ObjectModel;
using WPF_SEMANA02.Models;

namespace WPF_SEMANA02.Data;

public static class AppData
{
    public static ObservableCollection<Salida> Salidas { get; } = new()
    {
        new Salida { TipoDocumento = "RUC", NumeroDocumento = "20111111111", Peso = 8500, TipoAuto = "Camión", NombreTransportista = "Transportes Lima SAC", FechaYHora = new DateTime(2026, 9, 3, 10, 30, 0), PesoIngreso = 12000, PesoSalida = 8500 },
        new Salida { TipoDocumento = "RUC", NumeroDocumento = "20222222222", Peso = 6200, TipoAuto = "Tráiler", NombreTransportista = "Carga Express", FechaYHora = new DateTime(2026, 9, 3, 11, 0, 0), PesoIngreso = 10000, PesoSalida = 6200 }
    };

    public static ObservableCollection<Camion> Camiones { get; } = new()
    {
        new Camion { Placa = "ABC-123", PesoMaximo = 15000, PesoVacio = 5000 }
    };

    public static ObservableCollection<Transportista> Transportistas { get; } = new();
    public static ObservableCollection<Producto> Productos { get; } = new();

    public static ObservableCollection<Ingreso> Ingresos { get; } = new()
    {
        new Ingreso { Fecha = DateTime.Today, Peso = 12000, TipoVehiculo = "Camión", Transportista = "Transportes Lima SAC" }
    };
}
