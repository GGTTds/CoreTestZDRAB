using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TZERC.Inrf
{
    public interface IAvtorization
    {
        public Task<bool> LoginInAsync(string log, string pas);
        public Task<bool> RegisAsync(User x);
        public Task<bool> RegistAddUserData(string s, string d);
    }
}
