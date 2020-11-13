using System;
using System.Runtime.InteropServices;
using BitwiseCalculator;

namespace BitwiseCalculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            run();
        }

        
        public static void run()
        {
            while (true)
            {
                Console.WriteLine("@ 원하시는 작업을 선택해주세요");
                Console.WriteLine("# 1 BitWise AND 연산");
                Console.WriteLine("# 2 BitWise OR 연산");
                Console.WriteLine("# 3 종료");
                Console.WriteLine("-------------------");
                Console.Write("> ");
                
                
                string tmp = Console.ReadLine();

                if (tmp.Equals("3"))
                {
                    return;
                }
                else
                {
                    switch (tmp)
                    {
                        case "1" : 
                            while (true)
                            {
                                IBitwiseCalc calc = new BitANDClac();
                                string stra, strb, byteSize;
                                int size = 0;
                            
                                Console.WriteLine("\n\n# input Bit Padding Size");
                                Console.Write("> ");
                                byteSize = Console.ReadLine();
                                if (byteSize.Equals("q") || byteSize.Equals("e") || byteSize.Equals("ㅂ") || byteSize.Equals("ㄷ"))
                                {
                                    Console.WriteLine("\n\n");
                                    break;
                                }
                                size = Int32.Parse(byteSize);

                                Console.WriteLine("\n# input num 1");
                                Console.Write("> ");
                                stra = Console.ReadLine();
                                if (stra.Equals("q") || stra.Equals("e") || stra.Equals("ㅂ") || stra.Equals("ㄷ"))
                                {
                                    Console.WriteLine("\n\n");
                                    break;
                                } 

                                Console.WriteLine("\n# input num 2");
                                Console.Write("> ");
                                strb = Console.ReadLine();
                                if (strb.Equals("q") || strb.Equals("e") || strb.Equals("ㅂ") || strb.Equals("ㄷ"))
                                {
                                    Console.WriteLine("\n\n");
                                    break;
                                } 
            
                                Console.WriteLine(calc.operation(stra, strb, size));
                            }
                            break;
                        case "2" :
                            while (true)
                            {
                                IBitwiseCalc calc = new BitORClac();
                                string stra, strb, byteSize;
                                int size = 0;
                            
                                Console.WriteLine("# input Bit Padding Size");
                                Console.Write("> ");
                                byteSize = Console.ReadLine();
                                if (byteSize.Equals("q") || byteSize.Equals("e") || byteSize.Equals("ㅂ") || byteSize.Equals("ㄷ"))
                                {
                                    Console.WriteLine("\n\n");
                                    break;
                                }
                                size = Int32.Parse(byteSize);

                                Console.WriteLine("# input num 1");
                                Console.Write("> ");
                                stra = Console.ReadLine();
                                if (stra.Equals("q") || stra.Equals("e") || stra.Equals("ㅂ") || stra.Equals("ㄷ"))
                                {
                                    Console.WriteLine("\n\n");
                                    break;
                                } 

                                Console.WriteLine("# input num 2");
                                Console.Write("> ");
                                strb = Console.ReadLine();
                                if (strb.Equals("q") || strb.Equals("e") || strb.Equals("ㅂ") || strb.Equals("ㄷ"))
                                {
                                    Console.WriteLine("\n\n");
                                    break;
                                } 
            
                                Console.WriteLine(calc.operation(stra, strb, size));
                            }
                            break;
                    }
                }
            }
        }
    }
}