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
        if (dpFecha.SelectedDate is null || cmbTipo.SelectedItem is null ||
            string.IsNullOrWhiteSpace(txtTransportista.Text) ||
            !double.TryParse(txtPeso.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out double peso))
        {
            MessageBox.Show("Complete todos los campos y registre un peso válido.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        var tipoVehiculo = ((ComboBoxItem)cmbTipo.SelectedItem).Content.ToString()!;
        AppData.Ingresos.Add(new Ingreso
        {
            Fecha = dpFecha.SelectedDate.Value,
            Peso = peso,
            TipoVehiculo = tipoVehiculo,
            Transportista = txtTransportista.Text.Trim()
        });

        MessageBox.Show("Ingreso registrado correctamente.", "Información");
        LimpiarFormulario();
    }

    private void Limpiar_Click(object sender, RoutedEventArgs e) => LimpiarFormulario();

    private void LimpiarFormulario()
    {
        dpFecha.SelectedDate = DateTime.Today;
        txtPeso.Clear();
        cmbTipo.SelectedIndex = -1;
        txtTransportista.Clear();
    }

    private void Volver_Click(object sender, RoutedEventArgs e) => Close();
}
