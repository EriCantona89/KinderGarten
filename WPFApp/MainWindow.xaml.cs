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
using EFLib;
using WPFApp.ViewModels;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MenuViewModel();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new MenuViewModel();
        }

        private void Present_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new PresentViewModel();
        }

        private void Teacher_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new TeacherViewModel();
        }

        private void Parent_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ParentViewModel();
        }

        private void Children_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ChildrenViewModel();
        }
    }
}