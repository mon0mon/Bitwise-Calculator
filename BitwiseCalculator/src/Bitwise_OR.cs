using System;

namespace BitwiseCalculator
{
    public class BitORClac : IBitwiseCalc
    {
        // public string operation(int a, int b, int byteSize)
        // {
        //     byte num1, num2, tmp;
        //     string res;
        //
        //     num1 = Byte.Parse(a.ToString());
        //     num2 = Byte.Parse(b.ToString());
        //
        //     tmp = (byte) (num1 & num2);
        //     res = Convert.ToString(tmp, 2);
        //     return "binary : " + res.PadLeft(4, '0') + "\n" + "decimal : " + tmp.ToString();
        // }

        public string operation(string a, string b, int paddingSize)
        {
            string[] tmp1, tmp2, holderB1, holderB2;
            string holder1 = "", holder2 = "";
            string resDec = "", resBin = "", placeHolder;

            tmp1 = a.Split('.');
            tmp2 = b.Split('.');
            
            for (int i = 0; i < tmp1.Length; i++)
            {
                holder1 += Convert.ToString(long.Parse(tmp1[i]), 2).PadLeft(paddingSize, '0');
                holder1 += ".";
            }

            for (int i = 0; i < tmp2.Length; i++)
            {
                holder2 += Convert.ToString(long.Parse(tmp2[i]), 2).PadLeft(paddingSize, '0');
                holder2 += ".";
            }

            holderB1 = holder1.Split('.');
            holderB2 = holder2.Split('.');

            int length = holderB1.Length;
            holderB1[length-1] = "";
            holderB2[length-1] = "";

            for (int i = 0; i < length-1; i++)
            {
                placeHolder = "";
                for (int j = 0; j < holderB1[i].Length; j++)
                {
                    if (holderB1[i][j].Equals('1') || holderB2[i][j].Equals('1'))
                    {
                        placeHolder += "1";
                    }
                    else
                    {
                        placeHolder += "0";
                    }
                }
                
                if (i == length - 2)
                {
                    resBin += placeHolder;
                    resDec += Convert.ToInt32(placeHolder, 2).ToString();
                }
                else
                {
                    resBin += placeHolder + ".";
                    resDec += Convert.ToInt32(placeHolder, 2).ToString() + ".";
                }
            }

            return "\nBinary : " + resBin + "\nDecimal : " + resDec;
        }
    }
}