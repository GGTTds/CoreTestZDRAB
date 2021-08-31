using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TZERC.Inrf
{
    public interface ISaveDataUser
    {
        public Task<bool> Upd(DataUser x);
        public Task<bool> Upd(User x);
    }
}
