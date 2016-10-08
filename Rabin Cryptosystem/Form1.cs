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
            while ((p%4!=3) || (q%4!=3)||(prime(p)!=true)||(prime(q)!=true));
            int n = p * q;

            //encrypt
            string shifr = null;
            int xmsg, ymsg; ;
            string msg1 = null, msg2 = null, msg3 = null, msg4 = null;
            string opentxt = OpentxtBox.Text;
            for (int i = 0; i < opentxt.Length; i++)
            {
                shifr = shifr + Convert.ToChar(F_Pow(Convert.ToInt16(opentxt[i]), 2, n));
            }
            ShifrtxtBox.Text = shifr;
            //decrypt
            int k = (p + 1) / 4;
            int l = (q + 1) / 4;
            for (int i = 0; i < opentxt.Length; i++)
            {
                xmsg = F_Pow(Convert.ToInt16(shifr[i]), k, p);
                ymsg = F_Pow(Convert.ToInt16(shifr[i]), l, q);
                
            }

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
    }
}
