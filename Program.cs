namespace Lab_2_TalkingWithTheCustomer_Example_Code
{
    internal class Program
    {
        // Global Variables
        static string customer = "Josh";
        static string employee = "Will";
        static string company = "Starbucks";

        private static void Main(string[] args)
        {
            // Only method called in main is full conversation
            FullConversation();

        } // End main

        public static void FullConversation()
        {
            // Greeting
            EmployeeGreeting();
            // Customer Response - Order
            string order = CustomerResponse();
            // Options
            EmployeeListOptions(order);
            // Customer Response - Option
            string option = CustomerResponse();
            // Total
            EmployeTotalOrder(order, option);
            // Customer Response
            string leave = CustomerResponse();
            // Goodbye
            EmployeeGoodbye();

        } // FullConverstion();


        public static void EmployeeGreeting()
        {
            // Local Scope
            string order1 = "Green Peach Tea";
            string order2 = "Medicine Ball";

            // Employee Says Something - Greeting
            Console.WriteLine($"{employee}: Hi! Welcome to {company}. My name is {employee}.");
            Console.WriteLine($"Would you like to order a {order1}");
            Console.WriteLine($"or a {order2}");

        } // EmployeeGreeting

        public static void EmployeeGoodbye()
        {
            // Employee Says Something - Goodbye
            Console.WriteLine($"{employee}: Thank you for shopping at {company}");
        } // EmployeeGoodbye


        public static string CustomerResponse()
        {
            Console.Write($"{customer}:");
            // Readline is how we ask the user for information:
            return Console.ReadLine();
        } // CustomerResponse

        public static void EmployeeListOptions(string usersOrder)
        {
            string option1 = "Tall";
            string option2 = "Grande";
            string option3 = "Venti";
            string price1 = "$3.25";
            string price2 = "$3.75";
            string price3 = "$4.25";

            Console.WriteLine($"{employee}: Ok, so you want a {usersOrder} and what size would you like?");
            Console.WriteLine($"A {option1} for {price1}");
            Console.WriteLine($"A {option2} for {price2}");
            Console.WriteLine($"or a {option3} for {price3}");
        } // EmployeeListOptions

        public static void EmployeTotalOrder(string order, string option)
        {
            string total = "4.25";
            // Employee Respond - Total Order - The user will pass in the order
            Console.WriteLine($"{employee}: Ok, so thats a {option} {order} for {total}. Would you like anything else?");
        } // EmployeTotalOrder  

        public static void ExampleCode()
        {

            //// Employee Says Something - Greeting
            ////Console.WriteLine($"{employee}: Hi! Welcome to {company}. My name is {employee}.");
            ////Console.WriteLine($"Would you like to order a {order1}");
            ////Console.WriteLine($"or a {order2}");

            //// Customer
            ////Console.WriteLine($"{customer}: I would like a {order1}");

            //// Employee Respond - List Options - The user will pass in the order
            //// First line is where we repeat back the users order
            //Console.WriteLine($"{employee}: Ok, so you want a {order1} and what size would you like?");
            //Console.WriteLine($"A {option1} for {price1}");
            //Console.WriteLine($"A {option2} for {price2}");
            //Console.WriteLine($"or a {option3} for {price3}");

            //// Customer
            ////Console.WriteLine($"{customer}: Make it a {option2}");

            //// Employee Respond - Total Order - The user will pass in the order
            //Console.WriteLine($"{employee}: Ok, so thats a {option3} {order1} for {total}. Would you like anything else?");

            //// Customer
            ////Console.WriteLine($"{customer}: No thank you");

            //// Employee Says Something - Goodbye
            //Console.WriteLine($"{employee}: Thank you for shopping at {company}");
        }


        //Create a single method; you can call it FullConversation.Then call all your methods inside of here.You will then call FullConversation in Main.
        //If everything works properly, your conversation should look similar to lab 1, except you must type for the user. (What you type won't change what the customer says. But by week 4, you will learn conditions, allowing your code to change depending on what the user responds."

    } // End class

} // End namespace