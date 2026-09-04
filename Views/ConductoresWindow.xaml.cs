using System.Windows;
using WPF_SEMANA02.Data;

namespace WPF_SEMANA02.Views;

public partial class ConductoresWindow : Window
{
    public ConductoresWindow()
    {
        InitializeComponent();
        dgConductores.ItemsSource = AppData.Camiones;
    }

    private void Volver_Click(object sender, RoutedEventArgs e) => Close();
}
