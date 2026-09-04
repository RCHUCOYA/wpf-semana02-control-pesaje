using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using WPF_SEMANA02.Data;
using WPF_SEMANA02.Models;

namespace WPF_SEMANA02.Views;

public partial class IngresosWindow : Window
{
    public IngresosWindow()
    {
        InitializeComponent();
        LimpiarFormulario();
    }

    private void Guardar_Click(object sender, RoutedEventArgs e)
    {
        if (dpFecha.SelectedDate is null || cmbTipoDocumento.SelectedItem is null || cmbTipo.SelectedItem is null ||
            string.IsNullOrWhiteSpace(txtNumeroDocumento.Text) || string.IsNullOrWhiteSpace(txtPlaca.Text) ||
            string.IsNullOrWhiteSpace(txtTransportista.Text) || string.IsNullOrWhiteSpace(txtProducto.Text) ||
            !double.TryParse(txtPeso.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out double peso))
        {
            MessageBox.Show("Complete todos los campos y registre un peso válido.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        var tipoVehiculo = ((ComboBoxItem)cmbTipo.SelectedItem).Content.ToString()!;
        AppData.Ingresos.Add(new Ingreso
        {
            Fecha = dpFecha.SelectedDate.Value,
            TipoDocumento = ((ComboBoxItem)cmbTipoDocumento.SelectedItem).Content.ToString()!,
            NumeroDocumento = txtNumeroDocumento.Text.Trim(),
            Placa = txtPlaca.Text.Trim().ToUpper(),
            Peso = peso,
            TipoVehiculo = tipoVehiculo,
            Transportista = txtTransportista.Text.Trim(),
            Producto = txtProducto.Text.Trim(),
            Observacion = txtObservacion.Text.Trim()
        });

        MessageBox.Show("Ingreso registrado correctamente.", "Información");
        LimpiarFormulario();
    }

    private void Limpiar_Click(object sender, RoutedEventArgs e) => LimpiarFormulario();

    private void LimpiarFormulario()
    {
        dpFecha.SelectedDate = DateTime.Today;
        cmbTipoDocumento.SelectedIndex = -1;
        txtNumeroDocumento.Clear();
        txtPlaca.Clear();
        txtPeso.Clear();
        cmbTipo.SelectedIndex = -1;
        txtTransportista.Clear();
        txtProducto.Clear();
        txtObservacion.Clear();
    }

    private void Volver_Click(object sender, RoutedEventArgs e) => Close();
}
