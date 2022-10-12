using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public sealed class DBContextSingleTon : Context
    {
        private DBContextSingleTon() { }

        private static DBContextSingleTon instance;

        public static DBContextSingleTon GetDBContextInstance()
        {
            if (instance == null)
            {
                instance = new DBContextSingleTon();
            }
            return instance;
        }
    }

}
