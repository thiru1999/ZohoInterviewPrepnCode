using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoFindingGrandChildrenProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string child = Console.ReadLine();
            string father = Console.ReadLine();
            string grandChildrenFather = Console.ReadLine();
            string grandChildrenChild = string.Empty;
            string[] childArray = child.Split(',');
            string[] fatherArray = father.Split(',');
            int Arraylength = childArray.Length;
            int noOfGrandChild = 0;
            Dictionary<string, string> childFatherRelationDict = new Dictionary<string, string>();
            for(int iter = 0; iter < Arraylength; iter++)
            {
                childFatherRelationDict[childArray[iter]] = fatherArray[iter];

            }
            foreach(KeyValuePair<string,string> eachNode in childFatherRelationDict)
            {
                if (eachNode.Value == grandChildrenFather)
                {
                    grandChildrenChild = eachNode.Key;
                }

            }
            foreach (KeyValuePair<string, string> eachNode in childFatherRelationDict)
            {
                if (eachNode.Value == grandChildrenChild)
                {
                    noOfGrandChild++;
                    
                }

            }
            Console.WriteLine(noOfGrandChild);


        }
    }
}
