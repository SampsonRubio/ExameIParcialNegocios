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
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExameIParcialNegocios
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            Empleado empleado = new Empleado() { nombreEmpleado = NombreEmple.Text, identidad = Identidad.Text, horasTrabajadas = int.Parse(HorasT.Text), PagoNHT = double.Parse(PagoHNT.Text),
                horasExtra = int.Parse(HorasET.Text), PagoHET = double.Parse(PagoHET.Text) };

            double SSD = empleado.calculoSueldoSinDeducciones();
            double SHE = empleado.calculoSueldoPorHorasExtras();
            double ih = empleado.calculoIHSS();
            double ra = empleado.calculoRAP();
            double thot = empleado.calculoSueldoTotal();

            this.SueldoSinDeducciones.Text = SSD.ToString();
            this.SueldoPorHorasExtra.Text = SHE.ToString();
            this.IHSS.Text = ih.ToString();
            this.RAP.Text = ra.ToString();
            this.SueldoTotalDelEmpleado.Text = thot.ToString();

        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
