using System.Windows;

namespace WPF_SEMANA02.Views;

public partial class ReporteCargasWindow : Window
{
    public ReporteCargasWindow()
    {
        InitializeComponent();
        dgCargas.ItemsSource = new[]
        {
            new { Codigo = "CAR-001", Producto = "Mineral", Cantidad = 12500, Estado = "Registrada" },
            new { Codigo = "CAR-002", Producto = "Cemento", Cantidad = 8800, Estado = "En proceso" },
            new { Codigo = "CAR-003", Producto = "Arena", Cantidad = 6400, Estado = "Registrada" }
        };
    }

    private void Volver_Click(object sender, RoutedEventArgs e) => Close();
}
