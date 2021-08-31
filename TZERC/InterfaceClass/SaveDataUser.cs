using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TZERC.InterfaceClass
{
     public class SaveDataUser : Inrf.ISaveDataUser
    {
        public async Task<bool> Upd(DataUser x)
        {
            try
            {
                await using (TZERCBaseContext v = new TZERCBaseContext())
                {
                    v.DataUsers.Update(x);
                    await v.SaveChangesAsync();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> Upd(User x)
        {
            try
            {
                await using (TZERCBaseContext v = new TZERCBaseContext())
                {
                    v.Users.Update(x);
                    await v.SaveChangesAsync();
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
