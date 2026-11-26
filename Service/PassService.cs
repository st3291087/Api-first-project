using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class PassService : IPassService
    {
        public int Post(string pass)
        {
            int res= Zxcvbn.Core.EvaluatePassword(pass).Score;
            return res;

        }
    }
}
