using System;
public class Matrix_mul
{
    int a,b,c,d,e,f,g,h,i;
    public Matrix_mul(int s,int j,int l,int m,int n,int o, int p,int q,int r )
    {
        a= s;
        b= j;
        c= l;
        d= m;
        e= n;
        f= o;
        g= p;
        h= q;
        i= r;

    }
    public static Matrix_mul operator *(Matrix_mul op1,Matrix_mul op2)
    {
        Matrix_mul op = new Matrix_mul(op1.a * op2.a + op1.a * op2.d + op1.a * op2.g, op1.b * op2.b + op1.b * op2.e + op1.b * op2.h, op1.c * op2.c + op1.c * op2.f + op1.c * op2.i, op1.d * op2.a + op1.d * op2.d + op1.d * op2.g, op1.d * op2.b + op1.d * op2.e + op1.b * op2.h, op1.e * op2.a + op1.a * op2.d + op1.a * op2.g, op1.a * op2.a + op1.a * op2.d + op1.a * op2.g, op1.a * op2.a + op1.a * op2.d + op1.a * op2.g, op1.a * op2.a + op1.a * op2.d + op1.a * op2.g);
        return op;

    }
    public override string ToString()
    {
        return a + " " + b + " " + c + " " + "\n" + d + " " + e + " " + f + " " + "\n" + g + " " + h + " " + i + " " + "\n";
    }
}
public class testing
{
    public static void Main()
    {
        Matrix_mul m1 = new Matrix_mul(12, 25, 85,54,87,3,2,25,5);
        Matrix_mul m2 = new Matrix_mul(12, 25, 85, 54, 87, 3, 2, 25, 5);
        Matrix_mul m3 = m1 * m2;
        Console.WriteLine(m3);
    }
}