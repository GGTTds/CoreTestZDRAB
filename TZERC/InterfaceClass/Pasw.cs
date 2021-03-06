using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TZERC.InterfaceClass
{
    public class Pasw : Inrf.IPasw
    {
        public StringBuilder PasTry(string s)
        {
            StringBuilder de = new StringBuilder();
            if (s.Length < 6)
            {
                de.Append("Пароль слишком короткий\n");
            }
            if (s.Any(char.IsUpper) == false)
            {
                de.Append("Пароль должен содержать хотябы одну букву верхнего регистра\n");
            }
            if (s.Any(char.IsLower) == false)
            {
                de.Append("Пароль должен содержать хотябы одну букву нижнего регистра\n");
            }
            if (de.Length == 0)
            {
                return de;
            }
            else
            {
                return de;
            }
        }
    }
}
