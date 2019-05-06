using System;
using System.Collections.Generic;
using System.Text;

namespace Method_with_Return_and_Parameters
{
    class User
    {
        //auto implement properties, called directly inside the Main()
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int UserId { get; set; }

        //user age for driving licence eligibility 
        public string CheckUserAge()
        {
            if (Age < 18)
            {
                return "Your age is: " + Age + " \nYou are not allowed to drive a car yet";
            }

            else
            {
                return "Your age is: " + Age + " \nYou are allowed to drive a car";
            }
        }

        //provide a random user id
        public int UserID()
        {
            Random rand = new Random();
            UserId = rand.Next(1, 20);
            UserId++;
            return UserId;
        }

        //check if user id exists in the hardcoded database
        public int CheckUserExist(int id)
        {
            if (UserId > 0 &&  UserId < 10)
            {
                id = UserId;
                Console.WriteLine("Your details are in the database");
            }
            else
            {
                Console.WriteLine("Your details are not stored in the database");
            }
            return id;
        }
    }
}
