public class Solution
{
    public char NextGreatestLetter(char[] letters, char target)
    {
   
        int start = 0;
        char k = letters[0];
        int mid = 0;
        int end = letters.Length;
        while (start<=end)
        {
            mid = (start + end) / 2;
            if (letters[mid] > target)
            {
                k = letters[mid];

                end = mid - 1;

            }
            else if (letters[mid]==target)
            {
                return letters[mid];

            }
            else
            {
                
                start = mid+1;
            }
            
            

        }
        return k;

    }
    public static void Main()
    {
        char[] letter = new char[]  {'c', 'f', 'j'};
        char target = 'j';
        Solution s = new Solution();
        char op = s.NextGreatestLetter(letter, target);
        Console.WriteLine(op);


    }
}