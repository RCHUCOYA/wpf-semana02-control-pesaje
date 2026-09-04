using System.Windows;
using WPF_SEMANA02.Data;
using WPF_SEMANA02.Models;

namespace WPF_SEMANA02.Views;

public partial class ProductosWindow : Window
{
    public ProductosWindow()
    {
        InitializeComponent();
        dgProductos.ItemsSource = AppData.Productos;
    }

    private void Guardar_Click(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            MessageBox.Show("Ingrese código y nombre del producto.", "Validación");
            return;
        }

        AppData.Productos.Add(new Producto
        {
            Codigo = txtCodigo.Text.Trim(),
            Nombre = txtNombre.Text.Trim(),
            Descripcion = txtDescripcion.Text.Trim()
        });
        MessageBox.Show("Producto registrado correctamente.", "Información");
        LimpiarFormulario();
    }

    private void Limpiar_Click(object sender, RoutedEventArgs e) => LimpiarFormulario();

    private void LimpiarFormulario()
    {
        txtCodigo.Clear();
        txtNombre.Clear();
        txtDescripcion.Clear();
    }

    private void Volver_Click(object sender, RoutedEventArgs e) => Close();
}
