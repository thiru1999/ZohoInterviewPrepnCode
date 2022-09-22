using System;
using System.Collections;
using System.Collections.Generic;
public class rotate_array
{
    public List<int> Rotate(List<int> input_lists,int n,int d)
    {
        List<int> output_lists = new List<int>();
        for(int i = d; i < n; i++)
        {
            output_lists.Add(input_lists[i]);
            if (i == n-1)
            {
                int j = 0;
                while (j < d)
                {
                    output_lists.Add(input_lists[j]);
                    j++;
                }
            }

        }
        return output_lists;
    }
 
}
public class testing_function
{
    public static void Main()
    {
        int n, d;
        string[] sizein = Console.ReadLine().Split(' ');
        n=int.Parse(sizein[0]);
        d=int.Parse(sizein[1]);
        List<int> input = new List<int>();
        List<int> Final_output = new List<int>();
        string[] temp_string_input=Console.ReadLine().Split(' ');
        
        foreach(string s in temp_string_input)
        {
            int dummy;
            dummy = int.Parse(s);
            input.Add(dummy);

        }
        rotate_array rt = new rotate_array();
        Final_output=rt.Rotate(input,n,d);
        foreach(int i in Final_output)
        {
            Console.Write(i + " ");
        }


    }
}

