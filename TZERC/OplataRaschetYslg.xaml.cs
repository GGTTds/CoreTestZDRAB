using System;
using System.Collections.Generic;
using System.Text;
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
    /// Логика взаимодействия для OplataRaschetYslg.xaml
    /// </summary>
    public partial class OplataRaschetYslg : Window
    {
        DataUser g = new DataUser();
        public OplataRaschetYslg(float x1, float x2, float x3, float x4, float x5, float x6, float x7)
        {
            InitializeComponent();
            g.Id = GlobalDat.GlobalData.GlobalID;
            g.DataKey = GlobalDat.GlobalData.GlobalID;
            ToWindowData(x1, x2,  x3,  x4,  x5,  x6, x7);
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            InterfaceClass.SaveDataUser v = new InterfaceClass.SaveDataUser();
            await v.Upd(g);
            MessageBox.Show("Тут должна происходить оплата");
        }
        public void ToWindowData(float x1, float x2, float x3, float x4, float x5, float x6, float x7)
        {
            float Itog = x1 + x2 + x3 + x4 + x5 + x6 + x7;
            xvs.Content = x1.ToString();
            gvs.Content = x2.ToString();
            elt.Content = x5.ToString();
            eld.Content = x3.ToString();
            eltn.Content = x4.ToString();
            gvsp.Content = x6.ToString();
            gvsn.Content = x7.ToString();
            itog.Content = Itog.ToString();

        }
        public void GoDataUserUpd(double x1, double x2, double x3, double x4, double x5, double x6)
        {
            g.ColdWaterLaterMont = Math.Round(x1,3);
            g.HotWaterLatermount = Math.Round(x2,3);
            g.EltObh = Math.Round(x3,3);
            g.ElectLaterMountDay = Math.Round(x4,3);
            g.ElectLaterMountNight = Math.Round(x5,3);
            g.GvspodshLaterMount = Math.Round(x6,3);
            g.GVSPod = x6;
        }
        
    }
}
