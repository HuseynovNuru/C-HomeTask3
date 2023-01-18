using System;

namespace CHomeTask3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Verilmiş ədədlər siyahısındaki ədədlərdən ən kiçiyini tapan metod
            int[] numbers = { 49, 56, 43, 67, 10 };
            Console.WriteLine(Reqem(numbers));


            //Verilmiş yazıda verilmiş chardan neçə ədəd olduğunu tapan metod
            string word = "Herf";
            char chr = 'e';
            Console.WriteLine(Herf(word, chr));


            //Verilmiş ədədlər siyahısında verilmiş ədədin yerləşdiyi indexi tapan metod, əgər həmin ədəd siyahıda yoxdursa -1 qaytarsın, varsa ilk yerləşdiyi indexi.
            int[] ededler = { 12, 15, 45, 32, 57, 68, 99 };
            int axtarilan = 99;
            Console.WriteLine(IndexNums(ededler, axtarilan));


            //Verilmiş yazını əksinə çevirən metod
            string soz = "Salam";
            Console.WriteLine(Yazilar(soz));


            //Verilmiş yazıda rəqəm olub olmadığını tapan metod
            string letter = "Hello World";
            
            Console.WriteLine(Tapilmaq());
        }

        //Verilmiş ədədlər siyahısındaki ədədlərdən ən kiçiyini tapan metod
        static int Reqem(int[]numbers)
        {
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                {
                    min= numbers[i];
                }
            }
            return min;
        }
        


        
        //Verilmiş yazıda verilmiş chardan neçə ədəd olduğunu tapan metod 
        static int Herf(string str,char ch)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] ==ch)
                {
                    count++;
                }
            }
            return count;
        }
        

        
            //Verilmiş ədədlər siyahısında verilmiş ədədin yerləşdiyi indexi tapan metod, əgər həmin ədəd siyahıda yoxdursa -1 qaytarsın, varsa ilk yerləşdiyi indexi.
         static int IndexNums(int[]array , int findnums)
         {
             for (int i = 0; i < array.Length; i++)
             {
                if(findnums == array[i])
                {
                    return i;
                }
             }
             return -1;
         }


        //Verilmiş yazını əksinə çevirən metod
        static string Yazilar(string str)
        {
            string word = "";
            for (int i = str.Length-1 ;i>=0; i--)
            {
                word += str[i];
            }
            return word;
        }


        //Verilmiş yazıda rəqəm olub olmadığını tapan metod
        static bool Tapilmaq(string soz)
        {
            char[] ch = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            for (int i = 0; i < soz.Length; i++)
            {
                for (int j = 0; j < ch.Length; j++)
                {
                    if (ch[j] == soz[i])
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }



    }
}
