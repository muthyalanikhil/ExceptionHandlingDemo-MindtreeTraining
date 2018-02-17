using System;


namespace ExceptionHandlingExample
{
   public  class CustomException : Exception
    {
        public CustomException(): base()
        {
            Console.WriteLine("\nNumber is invalid input.Number is greater than 4.");
        }
    }
}
