using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 public class Program
    {
    public int Duplicates(string str)
    {
        int individual_count = 0;
        int overall_count = 0;
        var unique = new HashSet<char>(str);
        StringBuilder sb =new StringBuilder();
        foreach (char c in unique)
        {
            sb.Append(c);

        }
        string k = sb.ToString();
       // without duplicate value.
        for (int i = 0; i < k.Length; i++)
        {

            for(int j = 0; j < str.Length; j++)
            {
            
                if (k[i] == str[j])
                {
                    
                    ++individual_count;
                    
                }
            }
     
            
            if (individual_count > 1)
            {
                ++overall_count;
              
            }
            individual_count = 0;
        }
        return overall_count;

    }
    static void Main(string[] args)
    {
        Program k=new Program();
        int l = k.Duplicates("hello");
        Console.WriteLine(l);
    }
 }

