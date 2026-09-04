using System.Windows;

namespace WPF_SEMANA02.Views;

public partial class MantenimientosWindow : Window
{
    public MantenimientosWindow() => InitializeComponent();

    private void Conductores_Click(object sender, RoutedEventArgs e) => new ConductoresWindow().ShowDialog();
    private void Transportistas_Click(object sender, RoutedEventArgs e) => new TransportistasWindow().ShowDialog();
    private void Camiones_Click(object sender, RoutedEventArgs e) => new CamionesWindow().ShowDialog();
    private void Productos_Click(object sender, RoutedEventArgs e) => new ProductosWindow().ShowDialog();
    private void Volver_Click(object sender, RoutedEventArgs e) => Close();
}
