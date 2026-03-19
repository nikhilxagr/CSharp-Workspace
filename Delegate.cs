// .Net and C# Notes _

// Delegates - 
// The Dictionary meaning of Delegate is a person acting for another person . In C# it really means a methods acting for another method . A Delegates in c# is a class type object and is used to invoke a Method that has been  encapsulated into a at the type of its creation .Creating and using delegates involve 4 steps – 

// 1.	Delegate Declaration 
// 2.	Delegate method definition 
// 3.	Delegate Instatiation 
// 4.	Delegate invocation.
// A delegate declaration define a class using the class System.Delegate  as a Base Class . Delegate method are any function that is define in a class who signature is matches the delegate signature exactly. The Delegate instance hold the difference . The instance is used the method directly .

// An important feature is that it can be hold reference to method of any class the only requirement must be that , it signature must  match the signature must me method 

// Types Of Delegates

// There are 2 types of this – 
// 1-	Single Cast Delegate
// 2-	Multi Cast Delegate

// Single Cast Delegate – A single cast delegate is a delegate that can hold reference to only one method at a time . When you invoke a single cast delegate it will call the method that it is currently referencing . If you assign a new method to the same delegate instance it will replace the previous method reference .

// Multi Cast Delegate – A multi cast delegate is a delegate that can hold reference to multiple methods at the same time . When you invoke a multi cast delegate it will call all the methods that it is currently referencing in the order they were added . You can add method to a multi cast delegate using the += operator and remove method using the -= operator .

// Example of Single Cast Delegate

using System;

// Step 1: Delegate Declaration
delegate int ArthOPR(int x, int y);

class MathOperations
{
    // Step 2: Delegate method definition
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }
}

class DelegateTest 
{
    static void Main()
    {
        // Step 3: Delegate Instantiation
        ArthOPR op1 = new ArthOPR(MathOperations.Add);

        // Step 4: Delegate invocation
        int result = op1(10, 5);
        Console.WriteLine("Addition Result: " + result); // Output: Addition Result: 15

        // Changing the method reference to Subtract
        ArthOPR op2 = new ArthOPR(MathOperations.Subtract);
        result = op2(10, 5);
        
        Console.WriteLine("Subtraction Result: " + result); // Output: Subtraction Result: 5
    }
}