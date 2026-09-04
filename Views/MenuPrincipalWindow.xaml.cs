using System.Windows;

namespace WPF_SEMANA02.Views;

public partial class MenuPrincipalWindow : Window
{
    public MenuPrincipalWindow()
    {
        InitializeComponent();
    }

    private void Inicio_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Ya se encuentra en la pantalla de inicio.", "Inicio", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void Operaciones_Click(object sender, RoutedEventArgs e)
    {
        new OperacionesWindow().ShowDialog();
    }

    private void Mantenimientos_Click(object sender, RoutedEventArgs e)
    {
        new MantenimientosWindow().ShowDialog();
    }

    private void Reportes_Click(object sender, RoutedEventArgs e)
    {
        new ReportesWindow().ShowDialog();
    }

    private void CerrarSesion_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void Salir_Click(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }
}
