using System.Collections.ObjectModel;
using WPF_SEMANA02.Models;

namespace WPF_SEMANA02.Data;

public static class AppData
{
    public static ObservableCollection<Salida> Salidas { get; } = new();
}
