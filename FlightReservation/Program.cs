
using System.Runtime.CompilerServices;
/**
* Name: Kailie Field
* IDNumber:
* 
* Name: Jessica Lee
* IDNumber: 101445909
* 
* Name: Brendan Dasilva
* IDNumber:
* 1
* Name: Kevin Lapointe
* IDNumber: 101452430
**/

namespace FlightReservation
{
    class Program
    {
        private static Customer[] customers = new Customer[100];

        static void Main()
        {
            int choice = 0;
            while (true)
            {
                Console.WriteLine("XYZ AirLines Limited.\n---------------------");
                Console.WriteLine("\n1: Customer\n2: Flight\n3: Booking\n4: Exit");
                Console.Write("Please select a choice [1-4]: ");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter an integer value.\n");
                    continue;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Unexpected error happened.\n");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        CustomerMenu();
                        break;
                    case 2:
                        // Implement flightMenu
                        break;
                    case 3:
                        Console.WriteLine("Booking\n");
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("That is not a choice... Please choose another.\n");
                        break;
                }
            }
        }

        private static void CustomerMenu()
        {
            int choice = 0;
            while (true)
            {
                Console.WriteLine("XYZ AirLines Limited.\n---------------------");
                Console.WriteLine("Customer");
                Console.WriteLine("\n1: Add Customer\n2: View Customers\n3: Delete Customer\n4: Back to Main Menu");
                Console.Write("Please select a choice [1-4]: ");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter an integer value.\n");
                    continue;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Unexpected error happened.\n");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        ViewCustomers();
                        break;
                    // Implement Delete Customer method and case 3
                    case 4:
                        return;
                    default:
                        Console.WriteLine("That is not a choice... Please choose another.\n");
                        break;
                }
            }
        }

        private static void AddCustomer()
        {
            Console.WriteLine("Enter customer details:");

            // Get user input for customer details
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Phone: ");
            string phone = Console.ReadLine();

            // Check if the customer already exists
            if (CustomerExists(firstName, lastName, phone))
            {
                Console.WriteLine("Customer already exists.\n");
            }
            else
            {
                // Create a new customer and add it to the array
                Customer newCustomer = new Customer(firstName, lastName, phone);
                customers[newCustomer.CustomerId - 1] = newCustomer;
                Console.WriteLine("Customer added successfully.\n");
            }
        }

        private static void ViewCustomers()
        {
            Console.WriteLine("List of Customers:\n");

            // Go through the array and display customer information for non-null entries
            foreach (Customer customer in customers)
            {
                if (customer != null && !string.IsNullOrEmpty(customer.FirstName))
                {
                    customer.DisplayCustomerInfo();
                }
            }
        }


        private static bool CustomerExists(string firstName, string lastName, string phone)
        {
            foreach (Customer customer in customers)
            {
                if (customer != null && customer.IsSameCustomer(new Customer(firstName, lastName, phone)))
                {
                    return true;
                }
            }
            return false;
        }
    }

   
}


