using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace TZERC
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

        private async void RG_Copy_Click(object sender, RoutedEventArgs e)
        {
            string s1 = loggg.Text;
            string s2 = passs.Password;
            InterfaceClass.Avtorization v = new InterfaceClass.Avtorization();
            bool ThisDat = await Task.Run(() => v.LoginInAsync(s1, s2));
            if(ThisDat == true)
            {
                MainMenu b = new MainMenu();
                b.Show();
                Close();
            }    

        }

        private void RG_Click(object sender, RoutedEventArgs e)
        {
            Registr v = new Registr();
            v.ShowDialog();
        }
    }
}
