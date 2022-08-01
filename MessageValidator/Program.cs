using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime;
using System.Threading.Tasks;

namespace MessageValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            isAValidMessage1("4code13hellocodewars");
            Console.WriteLine(isAValidMessage1("1010COTEfbxzODjOCmtoNfrg10pOVUuMzcxl"));
            Console.ReadLine();
        }

        public static bool isAValidMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine(new string('-',14));
            int num = 0;            
            string result = null;
            string alphavit = "a b c d e f g h i j k l m n o p q r s t u v w x y z A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
            string[] arrayAlphavit = alphavit.Split(' ');
            string numbers = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40 41 42 43 44 45 46 47 48 49 50 51 52 53 54 55 56 57 58 59 60 61 62 63 64 65 66 67 68 69 70 71 72 73 74 75 76 77 78 79 80 81 82 83 84 85 86 87 88 89 90 91 92 93 94 95 96 97 98 99 100";
            string[] strArray = numbers.Split(' ');
            char[] chars = message.ToCharArray();
            string charss = "";
            int length = chars.Length;

            if (message.Length == 0)
            {
                return true;
            }
           
            if (Char.IsNumber(chars[length-1]))
            {
                return false;
            }            

            for (int i = 0; i < chars.Length; i++)
            {

                if (Char.IsNumber(chars[i]) && Char.IsNumber(chars[i+1]))
                {                                                                    
                            charss += $"{chars[i]}"+$"{chars[i+1]}"+" ";
                    i++;
                }     
                else
                    charss += chars[i] + " ";                                    
            }            
            string[] charsMessage = charss.Split(' ');

            for (int h = 0; h < arrayAlphavit.Length; h++)
            {
                if (charsMessage[0] == arrayAlphavit[h])
                {
                    Console.WriteLine(false);
                    return false;
                }
            }
                        
            for (int a = 0; a < charsMessage.Length; a++)
            {
                for (int j = 0; j < strArray.Length; j++)
                {
                    if (charsMessage[a] == strArray[j])
                    {
                        //int.TryParse(charsMessage[a], out num);                        
                       num += Convert.ToInt32(charsMessage[a]);
                    }
                }

            }
            /*if (charsMessage[a] == strArray[j])
            {
                num += Convert.ToInt32(charsMessage[a]);
            }*/
            Console.WriteLine(num);        

            for (int b = 0; b < charsMessage.Length; b++)
            {
                for (int d = 0; d < arrayAlphavit.Length; d++)
                {
                    if (charsMessage[b] == arrayAlphavit[d])
                    {
                        result += charsMessage[b];
                    }
                }
            }
            Console.WriteLine(result);
          
                if (result.Length == num)
                {
                    Console.WriteLine(true);
                    return true;
                }
                else                       
                                       
            return false;
        }


        public static bool isAValidMessage1(string message)
        {
            int number;
            for (int i = 0; i < message.Length; ++i)
            {
                if (!Char.IsNumber(message[i]))
                    return false;
                string amount = "";
                while (Char.IsNumber(message[i]))
                {
                    amount += message[i];
                    ++i;
                    if (i + Int32.Parse(amount) > message.Length)
                        return false;
                }
                number = Int32.Parse(amount);
                for (int j = 0; j < number; ++j)
                {
                    try
                    {
                        if (Char.IsNumber(message[i]))
                            return false;
                        ++i;
                    }
                    catch
                    {
                        return false;
                    }
                }
                --i;
            }
            return true;
        }
    }
}
