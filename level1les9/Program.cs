using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int PrintingCosts(string Line)
        {
            if (Line == null)
            {
                Console.WriteLine("initial conditions is false");
                return 0;
            }
            int l = 0;
            int sum = 0;
            int coefficient = 23;
            string[][] checkArray = new string[30][];
            checkArray[0] = new string[] { "0", " "};
            checkArray[1] = new string[] { "24", "&","#","A","y" };
            checkArray[2] = new string[] { "7", ",","-","^" };
            checkArray[3] = new string[] { "22", "2","0","Z","%","m" };
            checkArray[4] = new string[] { "23", "8","P","3","e","U","a"};
            checkArray[5] = new string[] { "10", ">","\\","/","<" };
            checkArray[6] = new string[] { "26", "D","9","E","W","6","O" };
            checkArray[7] = new string[] { "18", "J","n","]","{","X","}","f","I","[" };
            checkArray[8] = new string[] { "19", "V","z","w","1" };
            checkArray[9] = new string[] { "25", "b","d","p","G","S","q","H","N" };
            checkArray[10] = new string[] { "21", "h","K","4","k","s" };
            checkArray[11] = new string[] { "17", "t","c","u","*" };
            checkArray[12] = new string[] { "9", "!","~" };
            checkArray[13] = new string[] { "3", "'","`" };
            checkArray[14] = new string[] { "15", "?","i" };
            checkArray[15] = new string[] { "31", "Q" };
            checkArray[16] = new string[] { "20", "o","F","j","C" };
            checkArray[17] = new string[] { "6", "\"" };
            checkArray[18] = new string[] { "12", "(","|",")" };
            checkArray[19] = new string[] { "4", "." };
            checkArray[20] = new string[] { "8", ":","_" };
            checkArray[21] = new string[] { "32", "@" };
            checkArray[22] = new string[] { "16", "L","T","l","7" };
            checkArray[23] = new string[] { "28", "R","M" };
            checkArray[24] = new string[] { "13", "v","r","x","+" };
            checkArray[25] = new string[] { "27", "5" };
            checkArray[26] = new string[] { "11", ";" };
            checkArray[27] = new string[] { "14", "Y","=" };
            checkArray[28] = new string[] { "29", "$","B" };
            checkArray[29] = new string[] { "30", "g" };



            int t = checkArray.Length;
            for (int i = 0; i < checkArray.Length; i++)
            {
                //l = 0;
                int check = l;
                l = 0;
                for (int j = 1; j < checkArray[i].Length; j++)
                {
                    l = 0;
                    int t1 = checkArray[i].Length;
                    while (l < Line.Length)
                    {
                        if ((Line[l].ToString() == checkArray[i][j]))
                        {
                            int temp;
                            //Console.WriteLine(checkArray[i][0]);
                            temp = int.Parse(checkArray[i][0]);
                            sum = sum + temp;
                            Line = Line.Remove(l, 1);
                            l = l - 1;
                        }
                        l++;
                    }
                    //else Console.WriteLine(100);
                }

            }
            if (!String.IsNullOrEmpty(Line))
            {
                sum = sum + coefficient * Line.Length;
            }
            else sum = sum;
            //Console.WriteLine(Line+"=строка после");
            //Console.WriteLine(sum +"=сумма");
            return sum;
        }


        //static void Main(string[] args)
        //{
        //    string Line =" g";
        //    Console.WriteLine(Line);
        //    int sum = PrintingCosts(Line);
        //    Console.WriteLine(sum);

        //}

    }
}
