// C# program to show how 'base' keyword specifies 
// the base-class constructor that called from  
// derived class and also calling a method 'swap'  
// from derived class using base keyword 
using System;

// base class 
public class clssA
{

    public int n1, n2;

    // default constructor 
    public clssA()
    {
        Console.WriteLine("In clssA 'no argument constructor' invoked");
    }

    // parameterized constructor 
    public clssA(int i, int j)
    {

        // consturct values 
        n1 = i;
        n2 = j;
        Console.WriteLine("in clssA 'parameterized constructor' invoked");
        Console.WriteLine("the invoked values are " + n1 + " and " + n2);
        Console.WriteLine();
    }

    public virtual void swap()
    {
        Console.WriteLine("swap function of base class(clssA) invoked");
        Console.WriteLine("Before swap num1 = {0} and num2 = {1}", n1, n2);

        // swapping 
        int t = n1;
        n1 = n2;
        n2 = t;
        Console.WriteLine("After swap num1 = {0} and num2 = {1}", n1, n2);
    }
}

// derived class 
public class DerivedClass : clssA
{

    // This constructor will instantiate 
    // 'clssA' [no argument constructor] 
    // using 'base' keyword 
    public DerivedClass() : base() { }

    // This constructor will instantiate  
    // 'clssA' [parameterized constructor] 
    // using 'base' keyword 
    public DerivedClass(int i, int j) : base(i, j) { }

    public override void swap()
    {

        // it access the swap funtion of 
        // 'clssA' using 'base' keyword 
        base.swap();

        Console.WriteLine();

        Console.WriteLine("Swap function of derived class invoked");
        Console.WriteLine("Before swap num1 = {0} and num2 = {1}", n1, n2);

        // swapping 
        int t = n1;
        n1 = n2;
        n2 = t;
        Console.WriteLine("After swap num1 = {0} and num2 = {1}", n1, n2);
    }

    // Main Method 
    static void Main()
    {

        // invoke no argumanet constructor 
        DerivedClass d1 = new DerivedClass();

        Console.WriteLine();

        // invoke parameterized constructor 
        DerivedClass d2 = new DerivedClass(10, 20);

        // calling swap function 
        d2.swap();

    }
}

