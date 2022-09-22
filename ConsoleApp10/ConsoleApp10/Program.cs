/*using System;
using System.Collections.Generic;
public class data
{
    public string item
    {           //user define data type creation -data
        get; set;
    }
    public int price
    {
        get; set;
    }
    public int quantity
    {
        get; set;
    }
}

class complex_data
{
    public List<data> li { get; set; } = new List<data>();
  
    public static void Main()
    {
         //list collection initialization
        data d1 = new data();
        complex_data cd = new complex_data();
        //instatiating the userdefined datta type by object-d1
        d1.item = "MG ASTOR";
        d1.price = 2500000;		//adding the value to user defined datatype
        d1.quantity = 2;

        data d2 = new data();
        d2.item = "17t Pick and carry crane";
        d2.price = 2500000;
        d2.quantity = 1;



        cd.li.Add(d1);		//adding that user defined datat type to the list
        cd.li.Add(d2);


        foreach (data i in cd.li)
        {
            Console.WriteLine("item :{0};Price:{1};Quantity:{2}", i.item, i.price, i.quantity);
            Console.WriteLine($"{i.item} {i.price}");
        }


    }

}*/



using System;
class error_catching{
    public static void Main(){
        try{
            Console.WriteLine("enter the first no");
            int k=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the secondf no");
            int l=int.Parse(Console.ReadLine());
            if(l%2!=0){
                throw new Exception("Invalid Username or Password, Pls Check again and type");

            }
            int result=k/l;
            Console.WriteLine(result);
            
        }
        catch(DivideByZeroException D){
            Console.WriteLine(D.Message);
        }
        catch(Exception E){
            Console.WriteLine(E.Message);
        }
        Console.WriteLine("End weelll");
        
    }
        
}