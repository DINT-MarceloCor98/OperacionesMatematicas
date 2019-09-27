using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OperacionesMatematicas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DatosPorDefecto();
        }

        private void DatosPorDefecto()
        {
            Operando1TextBox.Text = "0";
            Operando2TextBox.Text = "0";
            SumaRadioButton.IsChecked = true;
        }

        private void SumaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ActualizarResultado();
        }

        private void RestaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ActualizarResultado();
        }

        private void MultiplicacionRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ActualizarResultado();
        }

        private void DivisionRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ActualizarResultado();
        }

        private void ActualizarResultado()
        {
            if (SumaRadioButton.IsChecked == true)
                ResultadoTextBox.Text = (double.Parse(Operando1TextBox.Text) + double.Parse(Operando2TextBox.Text)).ToString();
            else if (RestaRadioButton.IsChecked == true)
                ResultadoTextBox.Text = (double.Parse(Operando1TextBox.Text) - double.Parse(Operando2TextBox.Text)).ToString();
            else if (MultiplicacionRadioButton.IsChecked == true)
                ResultadoTextBox.Text = (double.Parse(Operando1TextBox.Text) * double.Parse(Operando2TextBox.Text)).ToString();
            else if (DivisionRadioButton.IsChecked == true && double.Parse(Operando2TextBox.Text) != 0)
                ResultadoTextBox.Text = (double.Parse(Operando1TextBox.Text) / double.Parse(Operando2TextBox.Text)).ToString();
            else
                ResultadoTextBox.Text = "ERROR";
        }

        private void Operando1TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarResultado();
        }

        private void Operando2TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarResultado();
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            DatosPorDefecto();
        }
    }
}
