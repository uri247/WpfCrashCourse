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

namespace WpfCrashCourse
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

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            this.RightPanel.Background = this.Resources["RightPanelBrash"] as Brush;
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A crash course in WPF", "Hello", MessageBoxButton.OK, MessageBoxImage.Information) ;
        }

        private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void Exit_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
