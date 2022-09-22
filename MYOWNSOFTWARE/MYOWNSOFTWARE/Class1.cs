using System;
class extension{
    public void method1(){
        Console.WriteLine("method1");
        
    }
    public void method2(){
        Console.WriteLine("method1");
        
    }
}
static class extension_checking{
    public static void method3(this extension e1,int i){
        Console.WriteLine("method3 "+i);
      
        
    }
    public static double Factorial(this Int32 x){   //X=> IS A identifier,extension method must be static.Here we are extending the int32 in order to do the Factorial method.
        if(x==1){
            return 1;
        }if(x==2){
            return 2;
        }
        else{
            return x*Factorial(x-1);
        }
    }
    
    
}

class extension_checking_checking{
    double k;
    public static void Main(){
        
        extension e2=new extension();
        extension_checking_checking k1=new extension_checking_checking();
        e2.method3(110);
        int i=5;
        k1.k=i.Factorial();
        
        Console.WriteLine(k1.k);
        
    }
    
}

