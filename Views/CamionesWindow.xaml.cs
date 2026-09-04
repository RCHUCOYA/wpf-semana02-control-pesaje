using System.Globalization;
using System.Windows;
using WPF_SEMANA02.Data;
using WPF_SEMANA02.Models;

namespace WPF_SEMANA02.Views;

public partial class CamionesWindow : Window
{
    public CamionesWindow()
    {
        InitializeComponent();
        dgCamiones.ItemsSource = AppData.Camiones;
    }

    private void Guardar_Click(object sender, RoutedEventArgs e)
    {
        double pesoMaximo = 0;
        double pesoVacio = 0;
        bool datosInvalidos = string.IsNullOrWhiteSpace(txtPlaca.Text) ||
                              !double.TryParse(txtPesoMaximo.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out pesoMaximo) ||
                              !double.TryParse(txtPesoVacio.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out pesoVacio);
        if (datosInvalidos)
        {
            MessageBox.Show("Complete los campos con valores válidos.", "Validación");
            return;
        }

        AppData.Camiones.Add(new Camion { Placa = txtPlaca.Text.Trim().ToUpper(), PesoMaximo = pesoMaximo, PesoVacio = pesoVacio });
        MessageBox.Show("Camión registrado correctamente.", "Información");
        LimpiarFormulario();
    }

    private void Nuevo_Click(object sender, RoutedEventArgs e) => LimpiarFormulario();
    private void Limpiar_Click(object sender, RoutedEventArgs e) => LimpiarFormulario();

    private void LimpiarFormulario()
    {
        txtPlaca.Clear();
        txtPesoMaximo.Clear();
        txtPesoVacio.Clear();
        txtPlaca.Focus();
    }

    private void Volver_Click(object sender, RoutedEventArgs e) => Close();
}
