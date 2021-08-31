using Microsoft.EntityFrameworkCore;
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
    /// Логика взаимодействия для TarifDat.xaml
    /// </summary>
    public partial class TarifDat : Window
    {
        public  TarifDat()
        {
            InitializeComponent();
            GoDatGG(); //Хоть тут и нет async Task метода выполняется Асинхронно не блакируя основной поток
        }
        public async Task GoDatGG()
        {
            await using(TZERCBaseContext v = new TZERCBaseContext())
            {
                GT.ItemsSource = await v.Tarifs.ToListAsync();
            }
        }
    }
}
