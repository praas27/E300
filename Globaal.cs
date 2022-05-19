
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E300
{
    public static class Globaal
    {
        public static readonly string[] serWaarde = new string[19] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s" };
        public static readonly string[] pinnen = new string[19] { "J3PIN1", "J1PIN8", "J1PIN10", "J1PIN11", "J2PIN5", "J3PIN3", "J7PIN14", "J1PIN4", "J1PIN6", "J1PIN7", "J7PIN15", "J7PIN4", "J7PIN5", "J7PIN6", "J7PIN10", "J1PIN5", "J2PIN2", "J2PIN3", "J2PIN1" };
        public static readonly string[] stat = new string[2] { "OK\n", "NOTOK\n" };
        public static readonly int ok = 0;
        public static readonly int notok = 1;

        public static int getCheckPin(string pin)
        {
            int i;
            switch (pin)
            {
                case "#J3PIN1":
                    i = 0;
                    break;
                case "#J1PIN8":
                    i = 1;
                    break;
                case "#J1PIN10":
                    i = 2;
                    break;
                case "#J1PIN11":
                    i = 3;
                    break;
                case "#J2PIN5":
                    i = 4;
                    break;
                case "#J3PIN3":
                    i = 5;
                    break;
                case "#J7PIN14":
                    i = 6;
                    break;
                case "#J1PIN4":
                    i = 7;
                    break;
                case "#J1PIN6":
                    i = 8;
                    break;
                case "#J1PIN7":
                    i = 9;
                    break;
                case "#J7PIN15":
                    i = 10;
                    break;
                case "#J7PIN4":
                    i = 11;
                    break;
                case "#J7PIN5":
                    i = 12;
                    break;
                case "#J7PIN6":
                    i = 13;
                    break;
                case "#J7PIN10":
                    i = 14;
                    break;
                case "#J1PIN5":
                    i = 15;
                    break;
                case "#J2PIN2":
                    i = 16;
                    break;
                case "#J2PIN3":
                    i = 17;
                    break;
                case "#J2PIN1":
                    i = 18;
                    break;
                default :
                    i = 19;
                    break;
            }
            return i;
        }
    }
}
