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
        dgSalidas.ItemsSource = AppData.Salidas;
        LimpiarFormulario();
    }

    private void Guardar_Click(object sender, RoutedEventArgs e)
    {
        if (!FormularioEsValido(out double peso, out double pesoIngreso, out double pesoSalida, out TimeSpan hora))
        {
            MessageBox.Show(
                "Complete todos los campos y escriba pesos numéricos válidos.",
                "Validación",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
            return;
        }

        var salida = new Salida
        {
            TipoDocumento = ObtenerTextoCombo(cmbTipoDocumento),
            NumeroDocumento = txtNumeroDocumento.Text.Trim(),
            Peso = peso,
            TipoAuto = ObtenerTextoCombo(cmbTipoAuto),
            NombreTransportista = txtTransportista.Text.Trim(),
            FechaYHora = dpFecha.SelectedDate!.Value.Date + hora,
            PesoIngreso = pesoIngreso,
            PesoSalida = pesoSalida
        };

        AppData.Salidas.Add(salida);

        MessageBox.Show(
            "Salida registrada correctamente.",
            "Información",
            MessageBoxButton.OK,
            MessageBoxImage.Information);

        LimpiarFormulario();
    }

    private bool FormularioEsValido(
        out double peso,
        out double pesoIngreso,
        out double pesoSalida,
        out TimeSpan hora)
    {
        peso = 0;
        pesoIngreso = 0;
        pesoSalida = 0;
        hora = TimeSpan.Zero;

        bool faltanCampos = cmbTipoDocumento.SelectedItem is null ||
                            cmbTipoAuto.SelectedItem is null ||
                            string.IsNullOrWhiteSpace(txtNumeroDocumento.Text) ||
                            string.IsNullOrWhiteSpace(txtTransportista.Text) ||
                            dpFecha.SelectedDate is null;

        bool pesosInvalidos = !double.TryParse(txtPeso.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out peso) ||
                              !double.TryParse(txtPesoIngreso.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out pesoIngreso) ||
                              !double.TryParse(txtPesoSalida.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out pesoSalida);

        bool horaInvalida = !TimeSpan.TryParse(txtHora.Text, out hora);

        return !faltanCampos && !pesosInvalidos && !horaInvalida;
    }

    private static string ObtenerTextoCombo(ComboBox combo)
    {
        return ((ComboBoxItem)combo.SelectedItem).Content.ToString()!;
    }

    private void Limpiar_Click(object sender, RoutedEventArgs e)
    {
        LimpiarFormulario();
    }

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

    private void Volver_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }
}
