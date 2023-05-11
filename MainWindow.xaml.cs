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

namespace WPF_Exel_quiz_11_05_2023_homework
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

        private void ButtonCansel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtOk_Click(object sender, RoutedEventArgs e)
        {
            LoginParol one = new LoginParol();
            one = (LoginParol)this.DataContext;
        }

        private void TextBoxLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBoxParol_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
