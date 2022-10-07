using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zohoa1b10c2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int length1 = input.Length;
            string num = "";
            
            char character = '\0';
            int c = 0;
            foreach(char i in input)
            {
                c += 1;

                if(i>='0' && i <= '9')
                {
                    num += i;
                }
                if (c == length1)
                {
                    int n = int.Parse(num);
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(character);

                    }
                    break;

                }
                if (i >= 'a' && i <='z')
                {
                    if (num != ""){
                        int n = int.Parse(num);
                        for(int j = 0; j < n; j++)
                        {
                            Console.Write(character);

                        }
                        character = i;
                        num = "";

                    }
                    character = i;




                    if (num=="")
                    {
                        continue;

                    }
                    
                }
                //if(i>='a'&& i<= 'z'){
                //    if (character != '\0' && num!="")
                //    {
                //        String s =character.Multiply(int.Parse(num)) ;
                //        Console.Write(s);
                //        character = i;
                //        num = "";
                        
                //    }

                //    else
                //    {
                //        character = i;

                //    }

                //}

                //if(i>='1' && i < '9')
                //{
                //    num += i;

                //}

            }
            //Console.Write(character.Multiply(int.Parse(num)));



        }
    }
    public static class ExtensionForChar
    {
        public static string Multiply(this char Character,int multiplier)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < multiplier; i++)
            {
                sb.Append(Character);
            }
            return sb.ToString();

        }
    }
}
