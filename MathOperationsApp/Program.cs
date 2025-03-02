// This is the main program file for the Math Operations Application
// It demonstrates creating a class with a method and calling it in different ways

// Namespace declaration for the application
namespace MathOperationsApp
{
    // Main Program class that contains the entry point of the application
    class Program
    {
        // The Main method is the entry point of the application
        static void Main(string[] args)
        {
            // Display a welcome message to the user
            Console.WriteLine("Math Operations Application");
            Console.WriteLine("---------------------------");
            
            // Instantiate the MathOperations class
            // This creates a new object of the MathOperations type
            MathOperations mathOps = new MathOperations();
            
            // Call the ProcessNumbers method passing two integers as positional parameters
            // This demonstrates calling a method with positional parameters
            Console.WriteLine("\nCalling method with positional parameters:");
            mathOps.ProcessNumbers(5, 10);
            
            // Call the ProcessNumbers method specifying the parameters by name
            // This demonstrates calling a method with named parameters
            Console.WriteLine("\nCalling method with named parameters:");
            mathOps.ProcessNumbers(firstNumber: 8, secondNumber: 16);
            
            // Wait for user input before closing the application
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
    
    // MathOperations class that contains methods for performing math operations
    class MathOperations
    {
        // ProcessNumbers method that takes two integers as parameters
        // It performs a math operation on the first number and displays the second number
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // Perform a math operation (squaring) on the first number
            int result = firstNumber * firstNumber;
            
            // Display the result of the math operation
            Console.WriteLine($"The square of the first number ({firstNumber}) is: {result}");
            
            // Display the second number as required
            Console.WriteLine($"The second number is: {secondNumber}");
        }
    }
}
