using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using WPF_SEMANA02.Data;
using WPF_SEMANA02.Models;

namespace WPF_SEMANA02.Views;

public partial class SalidasWindow : Window
{
    public SalidasWindow()
    {
        InitializeComponent();
        LimpiarFormulario();
    }

    private void Guardar_Click(object sender, RoutedEventArgs e)
    {
        if (!DatosValidos(out double peso, out double pesoIngreso, out double pesoSalida, out TimeSpan hora))
        {
            MessageBox.Show("Se deben completar los campos con valores numéricos válidos.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        AppData.Salidas.Add(new Salida
        {
            TipoDocumento = TextoSeleccionado(cmbTipoDocumento),
            NumeroDocumento = txtNumeroDocumento.Text.Trim(),
            Peso = peso,
            TipoAuto = TextoSeleccionado(cmbTipoAuto),
            NombreTransportista = txtTransportista.Text.Trim(),
            FechaYHora = dpFecha.SelectedDate!.Value.Date + hora,
            PesoIngreso = pesoIngreso,
            PesoSalida = pesoSalida
        });

        MessageBox.Show("Salida registrada correctamente.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        LimpiarFormulario();
    }

    private bool DatosValidos(out double peso, out double pesoIngreso, out double pesoSalida, out TimeSpan hora)
    {
        peso = 0;
        pesoIngreso = 0;
        pesoSalida = 0;
        hora = TimeSpan.Zero;

        bool camposVacios = cmbTipoDocumento.SelectedItem is null || cmbTipoAuto.SelectedItem is null ||
                            string.IsNullOrWhiteSpace(txtNumeroDocumento.Text) || string.IsNullOrWhiteSpace(txtTransportista.Text) ||
                            dpFecha.SelectedDate is null;
        bool pesosInvalidos = !double.TryParse(txtPeso.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out peso) ||
                              !double.TryParse(txtPesoIngreso.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out pesoIngreso) ||
                              !double.TryParse(txtPesoSalida.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out pesoSalida);

        return !camposVacios && !pesosInvalidos && TimeSpan.TryParse(txtHora.Text, out hora);
    }

    private static string TextoSeleccionado(ComboBox combo) => ((ComboBoxItem)combo.SelectedItem).Content.ToString()!;

    private void Limpiar_Click(object sender, RoutedEventArgs e) => LimpiarFormulario();

    private void LimpiarFormulario()
    {
        cmbTipoDocumento.SelectedIndex = -1;
        cmbTipoAuto.SelectedIndex = -1;
        txtNumeroDocumento.Clear();
        txtPeso.Clear();
        txtTransportista.Clear();
        txtPesoIngreso.Clear();
        txtPesoSalida.Clear();
        dpFecha.SelectedDate = DateTime.Today;
        txtHora.Text = DateTime.Now.ToString("HH:mm");
    }

    private void Volver_Click(object sender, RoutedEventArgs e) => Close();
}
