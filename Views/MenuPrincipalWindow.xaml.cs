using System.Windows;
namespace WPF_SEMANA02.Views;
public partial class MenuPrincipalWindow : Window
{
 public MenuPrincipalWindow() => InitializeComponent();
 private void Abrir(Window ventana) => ventana.ShowDialog();
 private void Inicio_Click(object s, RoutedEventArgs e) { }
 private void Ingresos_Click(object s, RoutedEventArgs e) => Abrir(new IngresosWindow()); private void Salidas_Click(object s, RoutedEventArgs e) => Abrir(new SalidasWindow());
 private void Conductores_Click(object s, RoutedEventArgs e) => Abrir(new ConductoresWindow()); private void Transportistas_Click(object s, RoutedEventArgs e) => Abrir(new TransportistasWindow()); private void Camiones_Click(object s, RoutedEventArgs e) => Abrir(new CamionesWindow()); private void Productos_Click(object s, RoutedEventArgs e) => Abrir(new ProductosWindow());
 private void Cargas_Click(object s, RoutedEventArgs e) => Abrir(new ReporteCargasWindow()); private void ReporteIngresos_Click(object s, RoutedEventArgs e) => Abrir(new ReporteIngresosWindow()); private void ReporteSalidas_Click(object s, RoutedEventArgs e) => Abrir(new ReporteSalidasWindow());
 private void CerrarSesion_Click(object s, RoutedEventArgs e) => Close(); private void Salir_Click(object s, RoutedEventArgs e) => Application.Current.Shutdown();
}
