﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backupGame
{
    class stringClassifier
    {
        public static bool getIP(string IP)
        {
            string[] numbers = IP.Split('.');

            bool isA = false;
            bool isB = false;
            bool isC = false;
            bool isD = false;

            if (numbers.Length == 4)
            {
                isA = Int32.TryParse(numbers[0], out int a);
                isB = Int32.TryParse(numbers[1], out int b);
                isC = Int32.TryParse(numbers[2], out int c);
                isD = Int32.TryParse(numbers[3], out int d);

            }
            if (isA & isB & isC & isD == true)
            {
                return true;
            }

            return false;
        }

    }
}
