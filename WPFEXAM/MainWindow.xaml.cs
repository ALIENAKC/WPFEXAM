using System;
using System.Windows;
using System.Windows.Navigation;
using WPFEXAM;
namespace WPFEEXAM
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window1
    {
       

        public MainWindow()
        {

            InitializeComponent();
        }

       
        private void Click1(object sender, RoutedEventArgs e)
        {
            Navigate(new Uri(@"C:\Users\Admin\source\repos\WPFEXAM\WPFEXAM\Window1.xaml", UriKind.Relative));
        }

        private void Navigate(Uri uri)
        {
            throw new NotImplementedException();
        }

    
    }
}