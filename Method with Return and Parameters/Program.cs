using System;

namespace Method_with_Return_and_Parameters
{
    class Program
    {
        static void Main()
        {
            int num = 6;
            int num1 = 5;
            int num2 = 3;
            int sumResult;
            int cubeNumber;
            int id = 0;
            int ide = 0;

            //call/use/instantiate the Calculate class 
            Calculate calculate = new Calculate();
            //use the class's methods
            Console.WriteLine("Sum is: " + calculate.Sum(num1, num2));

            Console.WriteLine("Cube is: " + calculate.Cube(num));
           
            //pass the data from Sum() to a new integer.
            sumResult = calculate.Sum(num1, num2);

            //pass the data from Cube() to a new integer.
            cubeNumber = calculate.Cube(num);

            //add the sumResult with the cubedNumber
            Console.WriteLine("Final is: " + calculate.Final(sumResult, cubeNumber));

            /************************************************************************/

            //call/use/instantiate the User class
            User user = new User();
            License license = new License();

            Console.WriteLine("Insert first name");
            user.FirstName = Console.ReadLine();
            Console.WriteLine("Insert last name");
            user.LastName = Console.ReadLine();
            Console.WriteLine("Insert age");
            user.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert your license ID");
            license.LicenseNumber = Console.ReadLine();

            string details = "First name: " + user.FirstName + "\nLast name: " + user.LastName;
            Console.WriteLine(details);

            string message = user.CheckUserAge();
            Console.WriteLine(message);

            string licenseCheck = license.CheckLicense();
            Console.WriteLine(licenseCheck);

            id = user.UserID();
            Console.WriteLine("Your User ID is: " + id);

            user.CheckUserExist(ide);
        }
    }
}
