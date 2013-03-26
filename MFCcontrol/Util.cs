using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFCcontrol
{
    class Util
    {
        public async Task LongDelay()
        {
            //simulate a long delay

            int b = await Task.Run(() =>
             {
                 //Task.Delay(10000);
                 for (int i = 0; i < 1000000000000000; i++)
                 {
                     i = i * 2;
                 }
                 return 1;

             });
        }
    }
}
