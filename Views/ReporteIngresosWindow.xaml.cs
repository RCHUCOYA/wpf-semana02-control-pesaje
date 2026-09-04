using System.Windows;
using WPF_SEMANA02.Data;

namespace WPF_SEMANA02.Views;

public partial class ReporteIngresosWindow : Window
{
    public ReporteIngresosWindow()
    {
        InitializeComponent();
        dgIngresos.ItemsSource = AppData.Ingresos;
    }

    private void Volver_Click(object sender, RoutedEventArgs e) => Close();
}
