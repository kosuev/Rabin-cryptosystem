using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rabin_Cryptosystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int p;
            int q;
            do
            {
                p = rand.Next(1, 99);
                q = rand.Next(1, 99);
            }
            while ((p%4!=3) || (q%4!=3)||(prime(p)!=true)||(prime(q)!=true)|| (p * q < 255));
            int n = p * q;

            //encrypt
            string shifr = null;            
            string opentxt = OpentxtBox.Text;
            for (int i = 0; i < opentxt.Length; i++)
            {
                shifr = shifr + Convert.ToChar(F_Pow(Convert.ToInt16(opentxt[i]), 2, n));
            }
            ShifrtxtBox.Text = shifr;
            //decrypt
            DshifrtxtBox.Text = "1."+China_function(shifr, p, q, 1, 1);
            
            

        }

        bool prime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        static int F_Pow(int x, int y, int mod)
        {
            int rez = 1;
            for (int i = 0; i < y; i++)
                rez = (rez * x) % mod;
            return (rez);
        }
        static int Mod(int key, int mod)
        {
            int x = mod;
            int a0 = 1, b0 = 0, a = 0, b = 1;
            int bufa, bufb;

            while (key % mod != 0)
            {
                int d = key / mod;
                int с = key % mod;
                bufa = a;
                bufb = b;
                a = a0 - a * d;
                b = b0 - b * d;
                key = mod;
                mod = с;
                a0 = bufa;
                b0 = bufb;
            }
           /* if (a < 0)
                return (a + x);
            else*/
                return (a);
        }
        static string China_function(string shifr, int p, int q, int xp, int yp)
        {
            string dshifr1 = null;
            string dshifr2 = null;
            string dshifr3 = null;
            string dshifr4 = null;
            for (int i = 0; i < shifr.Length; i++)
            {
                int k = (p + 1) / 4;
                int l = (q + 1) / 4;
                int n = p * q;
                int x = F_Pow(Convert.ToInt16(shifr[i]), k, p);
                int y = F_Pow(Convert.ToInt16(shifr[i]), l, q);
                x = x * xp;
                y = y * yp;
                int x1 = Mod(x, p);
                int y1 = Mod(y, q);
                int M1 = n / p;
                int M2 = n / q;
                int M11 = Mod(M1, p);
                int M21 = Mod(M2, q);
                int msg1 = (x1 * p * M21 + y1 * q * M11) % n;
                int msg2 = msg1 - n;
                int msg3= (x1 * p * M21 - y1 * q * M11) % n;
                int msg4 = msg3 - n;
                while ((msg1 < 0) || (msg2 < 0) || (msg3 < 0) || (msg4 < 0))
                {
                    msg1 = msg1 + 255;
                    msg2 = msg2 + 255;
                    msg3 = msg3 + 255;
                    msg4 = msg4 + 255;
                }
                dshifr1 = dshifr1 + Convert.ToChar(msg1 % 255);
                dshifr2 = dshifr2 + Convert.ToChar(msg2 % 255);
                dshifr3 = dshifr3 + Convert.ToChar(msg3 % 255);
                dshifr4 = dshifr4 + Convert.ToChar(msg4 % 255);
            }
            return (dshifr1+dshifr2+dshifr3+dshifr4);
        }
    }

}
