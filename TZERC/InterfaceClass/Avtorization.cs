using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;

namespace TZERC.InterfaceClass
{
    public class Avtorization : Inrf.IAvtorization
    {
     public async Task<bool> LoginInAsync(string log, string pas)
    {
            try
            {
                await using (TZERCBaseContext b = new TZERCBaseContext())
                {
                    var v = await b.Users.Where(p => p.Login.Equals(log)).Where(p => p.Password.Equals(pas)).FirstOrDefaultAsync();
                    var f = await b.DataUsers.Where(p => p.DataKey.Equals(v.Id)).FirstOrDefaultAsync();
                    if (v == null)
                    { 
                        MessageBox.Show(" Неправильный логин или пароль", "Ошибка");
                        return false;
                    }
                    else
                    {
                            GlobalDat.GlobalData.GlobalID =v.Id;
                            GlobalDat.GlobalData.GlobalIDForData = f.Id;
                            GlobalDat.GlobalData.HowPPLive = v.PersonThisLive;
                            GlobalDat.GlobalData.FIO = $"{v.Name} {v.Surnsme} {v.Patronymic}";
                            GlobalDat.GlobalData.Electro = v.PriborElect;
                            GlobalDat.GlobalData.GVS = v.PriborGvs;
                            GlobalDat.GlobalData.XVS = v.PriborXvs;
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }

    }
    public async Task<bool> RegisAsync(User x)
    {
            try
            {
                await using (TZERCBaseContext b = new TZERCBaseContext())
                {
                    b.Users.Add(x);
                    b.SaveChanges();
                }
                    return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> RegistAddUserData(string s, string d)
        {
            try
            {
                await using (TZERCBaseContext b = new TZERCBaseContext())
                {
                    var v = await b.Users.Where(p => p.Login.Equals(s)).Where(p => p.Password.Equals(d)).FirstOrDefaultAsync();
                    Task.Delay(20); // Сделано для того чтобы поток умпевал получить данные иначе может выкинкть Exception

                    DataUser t = new DataUser
                    {
                        DataKey = v.Id,
                        ColdWaterLaterMont = 0,
                        HotWaterLatermount = 0,
                        ElectLaterMountDay = 0,
                        ElectLaterMountNight = 0,
                        GvspodshLaterMount = 0,
                        GVSPod = 0,
                        EltObh = 0
                    };
                     b.DataUsers.Add(t);
                    await b.SaveChangesAsync();
                    
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
}
}
