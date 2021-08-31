using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TZERC
{
    /// <summary>
    /// Логика взаимодействия для Registr.xaml
    /// </summary>
    public partial class Registr : Window
    {
        public bool Xvs1 = false;
        public bool Gvs1 = false;
        public bool Elc1 = false;
        User NewUser = new User();
        public Registr()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            InterfaceClass.Avtorization u = new InterfaceClass.Avtorization();
            if (ForTry() == true)
            {
                if(ForTryPas().Length == 0)
                {
                    ReadPole();
                    u.RegisAsync(NewUser);
                    await u.RegistAddUserData(l.Text, pp.Password);
                    MessageBox.Show("Регистрация успешно завершена!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(ForTryPas().ToString());
                }
            }
            else
            {
                MessageBox.Show("Неккоректный Emai");
            }
        }

        public void ReadPole()
        {
            User t = new User
            {
                Name = n.Text,
                Surnsme = s.Text,
                Patronymic = o.Text,
                Phone = t1.Text,
                Email = po.Text,
                PersonThisLive = int.Parse(pro.Text),
                PriborXvs = Xvs1,
                PriborGvs = Gvs1,
                PriborElect = Elc1,
                Login = l.Text,
                Password = pp.Password
            };
            NewUser = t;
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (xs.IsChecked == true)
            {
                Xvs1 = true;
            }
            else
            {
                Xvs1 = true;
            }
        }

        private void CheckBox_Click_1(object sender, RoutedEventArgs e)
        {
            if (gs.IsChecked == true)
            {
                Gvs1 = true;
            }
            else
            {
                Gvs1 = true;
            }
        }

        private void CheckBox_Click_2(object sender, RoutedEventArgs e)
        {
            if (es.IsChecked == true)
            {
                Elc1 = true;
            }
            else
            {
                Elc1 = true;
            }
        }
        public bool ForTry()
        {

            InterfaceClass.EmlVal b = new InterfaceClass.EmlVal();
            bool g = b.IsValidEmail(po.Text);
            return g;
        }
        public StringBuilder ForTryPas()
        {
            InterfaceClass.Pasw b = new InterfaceClass.Pasw();
            StringBuilder v = b.PasTry(pp.Password);
            return v;
        }

        private void t1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }
    }
}
