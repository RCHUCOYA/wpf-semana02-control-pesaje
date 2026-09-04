using System.Windows;
using WPF_SEMANA02.Data;

namespace WPF_SEMANA02.Views;

public partial class ReporteSalidasWindow : Window
{
    public ReporteSalidasWindow()
    {
        InitializeComponent();
        MostrarTodasLasSalidas();
    }

    private void Buscar_Click(object sender, RoutedEventArgs e)
    {
        string texto = txtBuscarTransportista.Text.Trim();
        dgSalidas.ItemsSource = string.IsNullOrWhiteSpace(texto)
            ? AppData.Salidas
            : AppData.Salidas.Where(salida => salida.NombreTransportista.Contains(texto, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    private void Limpiar_Click(object sender, RoutedEventArgs e)
    {
        txtBuscarTransportista.Clear();
        MostrarTodasLasSalidas();
    }

    private void MostrarTodasLasSalidas() => dgSalidas.ItemsSource = AppData.Salidas;
    private void Volver_Click(object sender, RoutedEventArgs e) => Close();
}
