using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda2
{
    public static class zz
    {
        private static Form2 instance;
        

        public static Form2 GetInstance()
        {
            if (instance == null)
            {
                instance = new Form2();
            }

            return instance;

        }
       
    }
}
