using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsova.Class
{
    internal class ZamokLevel2
    {
        string password;
        string truePassword;
        Random random;
        public ZamokLevel2()
        {
            random = new Random();
            for (int i = 0; i < 3; i++)
            {
                truePassword += random.Next(10).ToString();
            }
        }

        public void RandomPasword()
        {
            truePassword = "";
            random = new Random();
            for (int i = 0; i < 3; i++)
            {
                truePassword += random.Next(10).ToString();
            }
        }
        public bool ChekPassword()
        {
            if (password == truePassword)
                return true;
            return false;

        }
        public void getPassword(string p)
        {
            password = p;
        }

        public string ReturnTruePassword()
        {
            return truePassword;
        }

    }
}
