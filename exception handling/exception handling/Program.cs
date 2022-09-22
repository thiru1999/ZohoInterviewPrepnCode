using System;
public class trycatch
{
    public static void Main()
    {
        int x, y, z;
        try
        {
            x = int.Parse(Console.ReadLine());
            if (x == 5)
            {
                throw new shouldnotbe5();
            }
            y = int.Parse(Console.ReadLine());
            z = x/y;
            

        }
        catch(shouldnotbe5 e)
        {
            Console.WriteLine(e);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e);
        }
        Console.WriteLine("AFTER CATCH");
    }
}
public class shouldnotbe5 : ApplicationException       //userdefined exception
{
    public override string Message                    //overriding the message property
    {
        get
        {
            return "Number should not be 5";
        }
    }

}