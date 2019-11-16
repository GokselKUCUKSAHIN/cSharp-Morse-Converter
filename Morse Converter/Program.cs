using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Morse_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Morse = new string[27];
            
            Morse[0] = "01s";//A
            Morse[1] = "0111s";//B
            Morse[2] = "1010s";   //C
            Morse[3] = "100s";    //D
            Morse[4] = "0s";      //E
            Morse[5] = "0010s";   //F
            Morse[6] = "110s";    //G
            Morse[7] = "0000s";   //H
            Morse[8] = "00s";     //I
            Morse[9] = "0111s";   //J
            Morse[10] = "101s";   //K
            Morse[11] = "0100s";  //L
            Morse[12] = "11s";    //M
            Morse[13] = "10s";    //N
            Morse[14] = "111s";   //O
            Morse[15] = "0110s";  //P
            Morse[16] = "1101s";  //Q
            Morse[17] = "010s";   //R
            Morse[18] = "000s";   //S
            Morse[19] = "1s";     //T
            Morse[20] = "001s";//U
            Morse[21] = "0001s";//V
            Morse[22] = "011s";//W
            Morse[23] = "1001s";//X
            Morse[24] = "1011s";//Y
            Morse[25] = "1100s";//Z
            Morse[26] = "s";// SPACE

            while (true)
            {
                var a = Console.ReadKey();
                int index = (int)a.KeyChar - 65;
                Console.WriteLine(a.KeyChar + " " + index);
                if(index == -33)
                {
                    index = 26;
                }
                //Console.WriteLine( " = " + Morse[index]);
                if((index >= 0) && (index <=26))
                {
                    TuneMorse(Morse[index]);
                }
            }
        }
        public static void TuneMorse(string data)
        {
            int hz = 800;
            foreach (char i in data)
            {
                if(i == '0')
                {
                    //dot
                    Console.Beep(hz,200);
                    Thread.Sleep(20);
                }
                else if(i == '1')
                {
                    //dash
                    Console.Beep(hz, 800);
                    Thread.Sleep(20);
                }
                else
                {
                    //blank space
                    Thread.Sleep(500);
                }
            }
        }
    }
}