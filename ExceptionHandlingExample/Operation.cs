using System;
using System.IO;

namespace ExceptionHandlingExample
{
    class Operation
    {
        public void ToPrint()
        {
            try
            {
                string name = new string('a', 2000000000);
                Console.WriteLine(name);
            }
            catch (OutOfMemoryException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        public void ToCheckNullException()
        {
            try
            {
                string input = null;
                Console.WriteLine(input.Length);
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine("\nNull exception caught.{0}", exception.Message);
            }

        }

        public void Add()
        {
            try
            {
                Console.WriteLine("\nEnter your choice: 1 or 2 or 3.");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice > 3)
                {

                    throw new CustomException();
                }

                switch (choice)
                {

                    case 1:
                        Console.WriteLine("case 1 selected");
                        break;


                    case 2:
                        Console.WriteLine("Case 2 Selected");
                        break;


                    case 3:
                        Console.WriteLine("case 3 selected");
                        break;

                }
            }
            
            catch (CustomException exception)
            {
                Console.WriteLine("\n{0}", exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }
    }
}
