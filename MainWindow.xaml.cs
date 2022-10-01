using System;
using System.Windows;
using System.Windows.Media;
using RenanIkedaFernandes_d7_avaliacao.Repository;
using RenanIkedaFernandes_d7_avaliacao.Controller;


namespace RenanIkedaFernandes_d7_avaliacao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private class userCredentials
        {
            public string username { get; set; } = String.Empty;
            public string password { get; set; } = String.Empty;
        }
        private userCredentials newUserInput = new(); 
        private readonly UsersController UserController;
        public MainWindow(AppDbContext context)
        {
            this.UserController = new UsersController(context);
            InitializeComponent();
            UsuarioTextBox.Background = new SolidColorBrush(Color.FromRgb(199, 199, 199));
            SenhaTextBox.Background = new SolidColorBrush(Color.FromRgb(199, 199, 199));
            userInput.DataContext = newUserInput;
        }
        private void onLogon(object s, RoutedEventArgs e)
        {
            bool login = this.UserController.Logon(this.newUserInput.username, this.newUserInput.password);

            if (login)
            {
                string messageBoxText = "Usuário autenticado! ";
                string caption = "Sucesso";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.None;
                MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            }
            else
            {
                string messageBoxText = "Credenciais inválidas";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            }
            this.newUserInput = new();
            userInput.DataContext = this.newUserInput;
        }
    }
}
