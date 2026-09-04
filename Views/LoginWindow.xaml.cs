using System.Windows;

namespace WPF_SEMANA02.Views;

public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
    }

    private void Ingresar_Click(object sender, RoutedEventArgs e)
    {
        var ventanaSalidas = new SalidasWindow();
        ventanaSalidas.ShowDialog();
    }

    private void Salir_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }
}
