using Microsoft.EntityFrameworkCore;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TZERC
{
    /// <summary>
    /// Логика взаимодействия для OplataUslg.xaml
    /// </summary>
    public partial class OplataUslg : Window
    {
        int count = 0;
        DataUser g = new DataUser();
        List<Tarif> t = new List<Tarif>();
        public InterfaceClass.SumYslForChet SY = new InterfaceClass.SumYslForChet();
        public InterfaceClass.SumYslForNonChet SY1 = new InterfaceClass.SumYslForNonChet();
        public OplataUslg()
        {
            InitializeComponent();
            ThisIsANonPribor();
            GoDat();
        }

        public async Task GoDat()
        {
            await using(TZERCBaseContext b = new TZERCBaseContext())
            {
                g = await b.DataUsers.Where(p => p.DataKey == GlobalDat.GlobalData.GlobalID).FirstOrDefaultAsync();
                await Dispatcher.BeginInvoke(GoData);
                t = await b.Tarifs.ToListAsync();

            }
            
        }
        public void ThisIsANonPribor()
        {
            if(GlobalDat.GlobalData.GVS == false)
            {
                v2.Visibility = Visibility.Hidden;
                t3.Visibility = Visibility.Hidden;
                t4.Visibility = Visibility.Hidden;
                v5.Visibility = Visibility.Hidden;
                t9.Visibility = Visibility.Hidden;
                t10.Visibility = Visibility.Hidden;
                count++;

            }
            if (GlobalDat.GlobalData.XVS == false)
            {
                v1.Visibility = Visibility.Hidden;
                t2.Visibility = Visibility.Hidden;
                t1.Visibility = Visibility.Hidden;
                count++;
            }
            if (GlobalDat.GlobalData.Electro == false)
            {
                v3.Visibility = Visibility.Hidden;
                t5.Visibility = Visibility.Hidden;
                t6.Visibility = Visibility.Hidden;
                v4.Visibility = Visibility.Hidden;
                t7.Visibility = Visibility.Hidden;
                t8.Visibility = Visibility.Hidden;
                count++;
            }
            if (count == 3)
            {
                Warn.Visibility = Visibility.Visible;

            }

        }
        public void GoData()
        {
            t1.Text = g.ColdWaterLaterMont.ToString();
            t3.Text = g.HotWaterLatermount.ToString();
            t5.Text = g.ElectLaterMountDay.ToString();
            t7.Text = g.ElectLaterMountNight.ToString();
            t9.Text = g.GVSPod.ToString();

        }

        private void Ras_Click(object sender, RoutedEventArgs e)
        {
            Rasc();
        }
        public void Rasc()
        {
            double SumGvs = 0;
            double SumXvs = 0;
            double Elt = 0;
            double SumElcDay1 = 0;
            double SumElcNigt = 0;
            double GasPod = 0;
            double GasNag = 0;
            double DataEltNonChet = 0;
            try
            {
                if (v1.Visibility == Visibility.Visible)
                {
                    var ThisTarif2 = t.Where(p => p.Name.Equals("ХВС")).FirstOrDefault();
                    SumXvs = SY.SumXvs((double)g.ColdWaterLaterMont, double.Parse(t2.Text), (double)ThisTarif2.Tarif1);
                }
                else
                {
                    var ThisTarif3 = t.Where(p => p.Name.Equals("ХВС")).FirstOrDefault();
                    SumXvs = SY1.SumNonDataXVS((double)ThisTarif3.Norma, (double)ThisTarif3.Tarif1);
                    t2.Text = ThisTarif3.Norma.ToString();
                }
                if (v2.Visibility == Visibility.Visible)
                {
                    var ThisTarif = t.Where(p => p.Name.Equals("ГВС")).FirstOrDefault();
                    SumGvs = SY.SumGvs((double)g.HotWaterLatermount, double.Parse(t4.Text), (double)ThisTarif.Tarif1);
                }
                else
                {
                    var ThisTarif1 = t.Where(p => p.Name.Equals("ГВС")).FirstOrDefault();
                    SumGvs = SY1.SumNonDataGVS((double)ThisTarif1.Norma, (double)ThisTarif1.Tarif1);
                    t4.Text = ThisTarif1.Norma.ToString();
                }
                if (v3.Visibility == Visibility.Visible)
                {
                    var ThisTarif4 = t.Where(p => p.Name.Equals("ЭЭДень")).FirstOrDefault();
                    SumElcDay1 = SY.SumElD((double)g.ElectLaterMountDay, double.Parse(t6.Text), (double)ThisTarif4.Tarif1);
                }
                else
                {
                    var ThisTarif5 = t.Where(p => p.Name.Equals("ЭЭ")).FirstOrDefault();
                    Elt = SY1.SumNonDataELdat((double)ThisTarif5.Norma, (double)ThisTarif5.Tarif1);
                    DataEltNonChet = (double)ThisTarif5.Norma;
                    t6.Text = "0";
                }
                if (v4.Visibility == Visibility.Visible)
                {
                    var ThisTarif6 = t.Where(p => p.Name.Equals("ЭЭНочь")).FirstOrDefault();
                    SumElcNigt = SY.SumElN((double)g.ElectLaterMountNight, double.Parse(t8.Text), (double)ThisTarif6.Tarif1);
                }
                else
                {
                    var ThisTarif7 = t.Where(p => p.Name.Equals("ЭЭ")).FirstOrDefault();
                    Elt = SY1.SumNonDataELdat((double)ThisTarif7.Norma, (double)ThisTarif7.Tarif1);
                    t8.Text = "0";
                }
                if (v5.Visibility == Visibility.Visible)
                {
                    var ThisTarif8 = t.Where(p => p.Name.Equals("ГВСПодача")).FirstOrDefault();
                    var ThisTarifNag9 = t.Where(p => p.Name.Equals("ГВСНагрев")).FirstOrDefault();
                    GasPod = SY.SumPod((double)g.GVSPod, double.Parse(t10.Text), (double)ThisTarif8.Tarif1);
                    GasNag = SY.SumNag((double)GasPod, (double)ThisTarifNag9.Norma);
                }
                else
                {
                    var ThisTarif10 = t.Where(p => p.Name.Equals("ГВСПодача")).FirstOrDefault();
                    GasPod = SY1.SumNonDataGVSPod((double)ThisTarif10.Norma, (double)ThisTarif10.Tarif1);
                    var ThisTarifNag11 = t.Where(p => p.Name.Equals("ГВСПодача")).FirstOrDefault();
                    GasNag = SY.SumNag((double)ThisTarifNag11.Norma, (double)ThisTarifNag11.Tarif1);
                    t10.Text = ThisTarif10.Norma.ToString();

                }
                if (SumXvs < 0 || SumGvs < 0 || SumElcDay1 < 0 || SumElcNigt < 0 || Elt < 0 || GasPod < 0 || GasNag <0)
                { throw new Exception();}
                OplataRaschetYslg h = new OplataRaschetYslg((float)SumXvs, (float)SumGvs, (float)SumElcDay1, (float)SumElcNigt, (float)Elt, (float)GasPod, (float)GasNag);
                h.GoDataUserUpd(double.Parse(t2.Text), double.Parse(t4.Text), DataEltNonChet, double.Parse(t6.Text), double.Parse(t8.Text), double.Parse(t10.Text));
                h.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Проверте правильно ли вы ввели значения!");
            }


        }
    }
}
