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

namespace RenanIkedaFernandes_d7_avaliacao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string userInput { get; set; } = String.Empty;
        private string passwordInput { get; set; } = String.Empty;
        public MainWindow()
        {
            InitializeComponent();
            UsuarioTextBox.Background = new SolidColorBrush(Color.FromRgb(199, 199, 199));
            SenhaTextBox.Background = new SolidColorBrush(Color.FromRgb(199, 199, 199));
        }
    }
}
