using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections;
using System.Security.Cryptography;

namespace Security_Code
{
    class SecurityCode
    {
        static void Main(string[] args)
        {
            Stopwatch timer1 = new Stopwatch();//计时器类
            timer1.Start();//开始计时
            SecurityCode c = new SecurityCode();
            int ilen = Convert.ToInt32(args[0]);//第一个参数
            int icount = Convert.ToInt32(args[1]);//第二个参数
            c.createSecurityCode(ilen, icount);
            timer1.Stop();//停止计时
            double dMilliseconds = timer1.Elapsed.TotalMilliseconds;
            Console.WriteLine("生成个数为：{0}，运行时间为：{1}", icount, dMilliseconds);
            Console.ReadKey();
        }
        /// <summary>
        /// 生成随机安全码
        /// </summary>
        /// <param name="len">安全码长度</param>
        /// <param name="count">安全码个数</param>
        public void createSecurityCode(int len, int count) 
        {
            string strTableChar = "0123456789ABCDEFGHJKLMNPQRSTUVWXYZ";
            StringBuilder codeStr = new StringBuilder(len);
            Random ro = new Random(GetRandomSeed());
            int iResult;
            int iup = strTableChar.Length;
            if (len < 1 || count < 1)
            {
                Console.WriteLine("输入值需为大于0的整数");
            }
            for (int i = count; i > 0; i--)
            {
                for (int j = len; j > 0; j--)
                {
                    iResult = ro.Next(iup);
                    codeStr.Append(strTableChar.Substring(iResult, 1));
                }
                //Console.WriteLine(codeStr);
                codeStr.Clear();
            }
        }
        /// <summary>
        /// System.Security.Cryptography.RNGCryptoServiceProvider 生成 Random 种子
        /// </summary>
        /// <returns></returns>
        static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
    }
}
