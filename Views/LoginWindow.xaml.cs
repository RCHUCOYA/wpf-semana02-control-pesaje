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
        Hide();
        new MenuPrincipalWindow().ShowDialog();
        Show();
    }

    private void Salir_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }
}
