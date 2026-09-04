using System.Windows;

namespace WPF_SEMANA02.Views;

public partial class ReportesWindow : Window
{
    public ReportesWindow() => InitializeComponent();

    private void Cargas_Click(object sender, RoutedEventArgs e) => new ReporteCargasWindow().ShowDialog();
    private void Ingresos_Click(object sender, RoutedEventArgs e) => new ReporteIngresosWindow().ShowDialog();
    private void Salidas_Click(object sender, RoutedEventArgs e) => new ReporteSalidasWindow().ShowDialog();
    private void Volver_Click(object sender, RoutedEventArgs e) => Close();
}
