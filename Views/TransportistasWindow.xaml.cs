using System.Windows;
using WPF_SEMANA02.Data;
using WPF_SEMANA02.Models;

namespace WPF_SEMANA02.Views;

public partial class TransportistasWindow : Window
{
    public TransportistasWindow()
    {
        InitializeComponent();
        dgTransportistas.ItemsSource = AppData.Transportistas;
    }

    private void Guardar_Click(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtRuc.Text))
        {
            MessageBox.Show("Ingrese nombre y RUC.", "Validación");
            return;
        }

        AppData.Transportistas.Add(new Transportista
        {
            Nombre = txtNombre.Text.Trim(),
            Ruc = txtRuc.Text.Trim(),
            Telefono = txtTelefono.Text.Trim()
        });
        MessageBox.Show("Transportista registrado correctamente.", "Información");
        LimpiarFormulario();
    }

    private void Limpiar_Click(object sender, RoutedEventArgs e) => LimpiarFormulario();

    private void LimpiarFormulario()
    {
        txtNombre.Clear();
        txtRuc.Clear();
        txtTelefono.Clear();
    }

    private void Volver_Click(object sender, RoutedEventArgs e) => Close();
}
