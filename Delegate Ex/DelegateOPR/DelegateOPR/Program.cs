using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOPR
{
    internal class Program
    {
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
    }
}