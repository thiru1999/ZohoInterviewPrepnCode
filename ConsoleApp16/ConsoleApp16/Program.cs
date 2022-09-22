using System;
using System.Collections.Generic;

public class sample
{
    public static void Main()
    {
        List<KeyValuePair<int, string>> MappingMinDistWithTaxi = new List<KeyValuePair<int, string>>();
        MappingMinDistWithTaxi.Add(new KeyValuePair<int, string>(1, "Mani"));
        MappingMinDistWithTaxi.Add(new KeyValuePair<int, string>(1, "kumasr"));
        MappingMinDistWithTaxi.Add(new KeyValuePair<int, string>(3, "kumasr"));
        MappingMinDistWithTaxi.Add(new KeyValuePair<int, string>(2, "kumasr"));

        MappingMinDistWithTaxi.Sort((x, y) => x.Key.CompareTo(y.Key));
        foreach(var k in MappingMinDistWithTaxi)
        {
            Console.WriteLine(k.Key);


        }

    }

}