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

namespace WpfAppcolopito
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
        private void RemoveColor_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            ColorsViewModel vm = (ColorsViewModel)DataContext;
            e.CanExecute = vm.RemoveCommand.CanExecute(e.Parameter);
        }

        private void RemoveColor_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ColorsViewModel vm = (ColorsViewModel)DataContext;
            vm.RemoveCommand.Execute(e.Parameter);
        }
    }
}

