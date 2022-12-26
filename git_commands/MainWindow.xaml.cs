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

namespace git_commands
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloneCommandBtnClick(object sender, RoutedEventArgs e)
        {
            CloneCommand window = new CloneCommand();
            window.Show();
        }
        private void ConfigCommandBtnClick(object sender, RoutedEventArgs e)
        {
            ConfigCommand window_config = new ConfigCommand();
            window_config.Show();
        }
    }
}
