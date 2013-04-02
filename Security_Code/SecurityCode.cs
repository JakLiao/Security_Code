using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections;

namespace Security_Code
{
    class SecurityCode
    {
        static void Main(string[] args)
        {
            Stopwatch timer1 = new Stopwatch();//计时器类
            timer1.Start();//开始计时
            SecurityCode c = new SecurityCode();
            int ilen = Convert.ToInt32(args[0]);
            int icount = Convert.ToInt32(args[1]);
            c.createSecurityCode(ilen, icount);
            timer1.Stop();//停止计时
            double dMilliseconds = timer1.Elapsed.TotalMilliseconds;
            Console.WriteLine("生成个数为：{0}，运行时间为：{1}", icount, dMilliseconds);
            Console.ReadKey();
        }

        public void createSecurityCode(int len, int count) 
        {
            string strTableChar = "0123456789ABCDEFGHJKLMNPQRSTUVWXYZ";
            Hashtable hashtable = new Hashtable(); 
            for (int i = count; i > 0; i--)
            {
                Random ro = new Random();
                int iResult;
                int iUp = 34;
                iResult = ro.Next(iUp);
                Console.WriteLine(iResult);
            }
        }
    }
}
