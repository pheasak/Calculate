using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    internal class Controller
    {
        public int number1, number2;
        public string total;
        public char op;
        public double sum;
        public string checking,lablenum="0",programmer="0",lableresult,bin,oct,hex,dec;
        public string delete(string text)// for standard calculator
        {
            int textLength = text.Length;
            if (textLength != 1)
            {
                lablenum = text.Remove(textLength - 1);
            }
            else
            {
                lablenum = 0.ToString();
            }
            return lablenum;
        }
        public string deletePro(string text,string check)
        {
            int textLength = text.Length;
            if (textLength != 1)
            {
                programmer = text.Remove(textLength - 1);// remove one length
                if (check.Equals("Hex"))
                {
                    Hex(programmer);
                }
                else if (check.Equals("Bin"))
                {
                    Binarycode(programmer);
                }
                else if (check.Equals("Dec"))
                {
                    Decimal(programmer);
                }
                else if (check.Equals("Oct"))
                {
                    Octal(programmer);
                }
            }
            else
            {
                programmer = 0.ToString();
                bin = programmer;
                oct = programmer;
                hex = programmer;
                dec = programmer;
            }
            return programmer;
        }
        public int BinaryToDecimal(string value)
        {
            char[] array = value.ToCharArray();
            Array.Reverse(array);
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    if (i == 0)
                    {
                        sum += 1;
                    }
                    else
                    {
                        sum += (int)Math.Pow(2, i);
                    }
                }

            }
            return sum;
        }
        public int BinaryToOctal(int value)
        {
            int OctalNo = 0, j, i = 1, BinaryNumber = value;
            for (j = BinaryToDecimal(value.ToString()); j > 0; j = j / 8)
            {
                OctalNo = OctalNo + (j % 8) * i;
                i = i * 10;
                BinaryNumber = BinaryNumber / 8;
            }
            return OctalNo;
        }
        public string BinaryToHex(int value)
        {
            string hex = value.ToString("X");
            return hex;
        }
        // =================== Decimal ===============
        public int DecimaltoBinary(int Value)
        {
            int rem, bin = 0, bases = 1;
            while (Value > 0)
            {
                rem = Value % 2;
                bin = bin + bases * rem;
                bases = bases * 10;
                Value = Value / 2;
            }
            return bin;
        }
        public int DecimaltoOctal(int Value)
        {
            int oct = 0, p = 1;
            for (int i = Value; i > 0; i = i / 8)
            {
                oct = oct + (i % 8) * p;
                p *= 10;
                Value /= 8;
            }
            return oct;
        }
        public string DecimaltoHex(int Value)
        {
            string hex = Value.ToString("X");
            return hex;
        }
        // ===================== Octal ================
        public int Octtobin(int Value)// Octal to binary
        {
            int k = 1, i = 1, d, decimal_number = 0, binary_number = 0;
            for (int j = Value; j > 0; j /= 10)//octal to decimal
            {
                d = j % 10;
                if (i == 1)
                    k *= 1;
                else
                    k *= 8;
                decimal_number = decimal_number + (d * k);
                i++;
            }
            i = 1;
            for (int j = decimal_number; j > 0; j /= 2)
            {
                binary_number = binary_number + (decimal_number % 2) * i;
                i *= 10;
                decimal_number /= 2;
            }
            return binary_number;
        }
        public int OctToDec(int Value)// Octal to Decimal
        {
            int k = 1, i = 1, d, decimal_number = 0;
            for (int j = Value; j > 0; j /= 10)
            {
                d = j % 10;
                if (i == 1)
                    k *= 1;
                else
                    k *= 8;
                decimal_number = decimal_number + (d * k);
                i++;
            }
            return decimal_number;
        }
        // =================== Hex ===============
        public int HextoDec(string hex)
        {
            int value = Convert.ToInt32(hex, 16);
            return value;
        }
        // ======================== Calculation Programmer ===============================
        public string typing(string c)
        {
            // when first typing.
            if (programmer == "0" && c == "1")
            {
                programmer = "1";
            }
            else if (programmer == "0" && c == "2")
            {
                programmer = "2";
            }
            else if (programmer == "0" && c == "3")
            {
                programmer = "3";
            }
            else if (programmer == "0" && c == "4")
            {
                programmer = "4";
            }
            else if (programmer == "0" && c == "5")
            {
                programmer = "5";
            }
            else if (programmer == "0" && c == "6")
            {
                programmer = "6";
            }
            else if (programmer == "0" && c == "7")
            {
                programmer = "7";
            }
            else if (programmer == "0" && c == "8")
            {
                programmer = "8";
            }
            else if (programmer == "0" && c == "9")
            {
                programmer = "9";
            }
            else if (programmer == "0" && c == "A")
            {
                programmer = "A";
            }
            else if (programmer == "0" && c == "B")
            {
                programmer = "B";
            }
            else if (programmer == "0" && c == "C")
            {
                programmer = "C";
            }
            else if (programmer == "0" && c == "D")
            {
                programmer = "D";
            }
            else if (programmer == "0" && c == "E")
            {
                programmer = "E";
            }
            else if (programmer == "0" && c == "F")
            {
                programmer = "F";
            }
            else
            {
                programmer = programmer + c;
            }
            return programmer;
        }
        public void choose(string check,string value)
        {
            if (check.Equals("Hex"))
            {
                Hex(value);
            }
            else if (check.Equals("Bin"))

            {
                Binarycode(value);
            }
            else if (check.Equals("Dec"))
            {
                Decimal(value);
            }
            else if (check.Equals("Oct"))
            {
                Octal(value);
            }
        }
        // convertion number
        public void Binarycode(string value)// binary
        {
            bin = value;
            dec = BinaryToDecimal(value).ToString();//binary to decimaml
            oct = BinaryToOctal(int.Parse(value)).ToString();// binary to octal
            hex = BinaryToHex(BinaryToDecimal(value));// binary to hex
        }
        public void Decimal(string value)
        {
            bin = DecimaltoBinary(int.Parse(value)).ToString();// decimal to binary
            dec = value;
            oct = DecimaltoOctal(int.Parse(value)).ToString(); // decimal to octal
            hex = DecimaltoHex(int.Parse(value)).ToString();// decimal to hex
        }
        public void Octal(string value)
        {
            oct = value;
            bin = Octtobin(int.Parse(value)).ToString();// octal to binary
            dec = OctToDec(int.Parse(value)).ToString();//octal to decimal
            hex = DecimaltoHex(OctToDec(int.Parse(value))).ToString();// octal to hex
        }
        public void Hex(string value)
        {
            hex = value;
            dec = HextoDec(value).ToString();//hex to decimal
            bin = DecimaltoBinary(HextoDec(value)).ToString();// hex to binary
            oct = DecimaltoOctal(HextoDec(value)).ToString();//hex to octal
        }
        // =========================== Standard =================================
        public void Pow(double num)
        {
            lablenum= Math.Pow(num, 2).ToString();
            lableresult= "(" + num + ")" + "^2".ToString();
        }
        public void Sprt(double num)
        {
            lablenum = Math.Sqrt(num).ToString();
            lableresult = "√(" + num + ")";
        }
        public void share(double num)
        {
            lablenum = (1 / num).ToString();
            lableresult = "1/(" + num + ")";
        }
        public string firstTyping(string ch)
        {
            if (lablenum == "0" && ch == "1")
            {
                lablenum = "1";
            }
            else if (lablenum == "0" && ch == "2")
            {
                lablenum = "2";
            }
            else if (lablenum == "0" && ch == "3")
            {
                lablenum = "3";
            }
            else if (lablenum == "0" && ch == "4")
            {
                lablenum = "4";
            }
            else if (lablenum == "0" && ch == "5")
            {
                lablenum = "5";
            }
            else if (lablenum == "0" && ch == "6")
            {
                lablenum = "6";
            }
            else if (lablenum == "0" && ch == "7")
            {
                lablenum = "7";
            }
            else if (lablenum == "0" && ch == "8")
            {
                lablenum = "8";
            }
            else if (lablenum == "0" && ch == "9")
            {
                lablenum = "9";
            }
            else
            {
                lablenum = lablenum  + ch;

            }
            return lablenum;
        }
    }
 }
