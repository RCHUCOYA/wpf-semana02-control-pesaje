using System.Windows;
namespace WPF_SEMANA02.Views;
public partial class LoginWindow : Window
{
    public LoginWindow() => InitializeComponent();
    private void Ingresar_Click(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasena.Password)) { MessageBox.Show("Debe ingresar usuario y contraseña.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning); return; }
        if (txtUsuario.Text != "admin" || txtContrasena.Password != "1234") { MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButton.OK, MessageBoxImage.Error); return; }
        Hide(); new MenuPrincipalWindow().ShowDialog(); Show();
    }
    private void Salir_Click(object sender, RoutedEventArgs e) => Close();
}
