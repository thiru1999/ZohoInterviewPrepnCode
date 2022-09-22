using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoWelcomeToZohoCorporationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] array2d = new char[5, 5];
            string MainString = Console.ReadLine();
            string subString = Console.ReadLine();
            int MainStringLength = MainString.Length;
            int subStringLength = subString.Length;
            int stateVariableToCheckAllSubstring = 0;
            int MainStringLengthDummyVariable = 0; //For Knowing the sate of Mainstring Leght
            int? rowTraversingStartIndex1 = null;
            int? rowTraversingStartIndex2 = null;
            int? rowTraversingEndIndex1 = null;
            int? rowTraversingEndIndex2 = null;
            int? columnTraversingStartIndex1 = null;
            int? columnTraversingStartIndex2 = null;
            int? columnTraversingEndIndex1 = null;
            int? columnTraversingEndIndex2 = null;
            for (int iter1 = 0; iter1 < 5; iter1++)
            {
                for (int iter2 = 0; iter2 < 5; iter2++)
                {
                    if (MainStringLengthDummyVariable < MainStringLength)
                    {
                        array2d[iter1, iter2] = MainString[MainStringLengthDummyVariable];
                        MainStringLengthDummyVariable++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            //Traversing through the row to find Substring Present or Not
            for (int iter3 = 0; iter3 < 5; iter3++)
            {
                for (int iter4 = 0; iter4 < 5; iter4++)
                {
                    if (subString[stateVariableToCheckAllSubstring] == array2d[iter3, iter4])
                    {
                        if (stateVariableToCheckAllSubstring == 0)
                        {
                            rowTraversingStartIndex1 = iter3;
                            rowTraversingStartIndex2 = iter4;

                        }

                        if (stateVariableToCheckAllSubstring == subStringLength - 1)
                        {
                            rowTraversingEndIndex1 = iter3;
                            rowTraversingEndIndex2 = iter4;
                            Console.WriteLine(rowTraversingStartIndex1 + " " + rowTraversingStartIndex2);
                            Console.WriteLine(rowTraversingEndIndex1 + " " + rowTraversingEndIndex2);
                            stateVariableToCheckAllSubstring = 0;
                            break;

                        }
                        stateVariableToCheckAllSubstring++;
                    }
                    else
                    {
                        stateVariableToCheckAllSubstring = 0;
                        rowTraversingStartIndex1 = null;
                        rowTraversingStartIndex2 = null;
                      
                    }
                }
            }
            //Traversing throught the Column to find substring Present or Not

            for (int iter3 = 0; iter3 < 5; iter3++)
            {
                for (int iter4 = 0; iter4 < 5; iter4++)
                {
                    if (subString[stateVariableToCheckAllSubstring] == array2d[iter4, iter3])
                    {
                        if (stateVariableToCheckAllSubstring == 0)
                        {
                            columnTraversingStartIndex1 = iter3;
                            columnTraversingStartIndex2 = iter4;

                        }

                        if (stateVariableToCheckAllSubstring == subStringLength - 1)
                        {
                            columnTraversingEndIndex1 = iter3;
                            columnTraversingEndIndex2 = iter4;
                            Console.WriteLine(columnTraversingStartIndex2 + " " + columnTraversingStartIndex1);
                            Console.WriteLine(columnTraversingEndIndex2 + " " + columnTraversingEndIndex1);
                            stateVariableToCheckAllSubstring = 0;
                            break;

                        }
                        stateVariableToCheckAllSubstring++;
                    }
                    else
                    {
                        stateVariableToCheckAllSubstring = 0;
                        columnTraversingStartIndex1 = null;
                        columnTraversingStartIndex2 = null;
                    }
                }
            }

        }
    }
}
