using System;

namespace FlightReservation
{
    internal class Customer
    {
        private static int nextCustomerId = 1;
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public int NumberOfBookings { get; private set; }

        public Customer(string firstName, string lastName, string phone)
        {
            CustomerId = nextCustomerId++;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            NumberOfBookings = 0;
        }

        public void AddBooking()
        {
            NumberOfBookings++;
        }

        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"Customer ID: {CustomerId}");
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Number of Bookings: {NumberOfBookings}");
            Console.WriteLine();
        }

        public bool IsSameCustomer(Customer other)
        {
            if (other == null)
            {
                return false;
            }

            // Check for null or empty strings before comparison
            return !string.IsNullOrEmpty(FirstName) &&
                   !string.IsNullOrEmpty(other.FirstName) &&
                   FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase) &&
                   !string.IsNullOrEmpty(LastName) &&
                   !string.IsNullOrEmpty(other.LastName) &&
                   LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase) &&
                   !string.IsNullOrEmpty(Phone) &&
                   !string.IsNullOrEmpty(other.Phone) &&
                   Phone.Equals(other.Phone, StringComparison.OrdinalIgnoreCase);
        }


    }
}
