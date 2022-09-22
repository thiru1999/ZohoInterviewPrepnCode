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
            string num = "";
            char character = '\0';
            foreach(char i in input)
            {
                if(i>='a'&& i<= 'z'){
                    if (character != '\0' && num!="")
                    {
                        String s =character.Multiply(int.Parse(num)) ;
                        Console.Write(s);
                        character = i;
                        num = "";
                        
                    }

                    else
                    {
                        character = i;

                    }

                }

                if(i>='1' && i < '9')
                {
                    num += i;

                }

            }
            Console.Write(character.Multiply(int.Parse(num)));



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
