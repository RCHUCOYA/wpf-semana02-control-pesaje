using System.Windows;

namespace WPF_SEMANA02.Views;

public partial class OperacionesWindow : Window
{
    public OperacionesWindow() => InitializeComponent();

    private void Ingresos_Click(object sender, RoutedEventArgs e) => new IngresosWindow().ShowDialog();
    private void Salidas_Click(object sender, RoutedEventArgs e) => new SalidasWindow().ShowDialog();
    private void Volver_Click(object sender, RoutedEventArgs e) => Close();
}
