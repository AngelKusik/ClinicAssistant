// Author:              Angelica Kusik (based on prof Kyle Chapman work)
// Last Modified by:    Angelica Kusik
// Original Date:       March 17, 2021
// Last Modified Date:  March 18, 2022
// Project Name:        CustomerClass.cs
// Course:              NETD 2202
// Description:
//  Lab #4 - CuatomerClass.cs 
//  This file contains the customer class that was create to record information such as 
//  first name, last name, and contact of customers that were entered on the contact tracer form
//  while keeping track of whether the customer has been contacted or not. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAssistant
{
    /// <summary>
    /// A class designed to record individual customers, including if they were contacted or not.
    /// </summary>
    class CustomerClass
    {
        //Static Private readonly variable to hold the number of customers. 
        //TODO: Should it include readonly on the declaration??
        private static int Count = 0;

        //Private readonly variable to hold the customers unique id.
        //TODO: Should it include readonly on the declaration??
        private readonly int Id = 0;

        //Private boolean variable to determine if the customer was contacted or not.
        private bool ContactStatus = false;

        //Private variable to hold the customer's first name.
        private string FirstName = String.Empty;

        //Private variable to hold the customer's last name.
        private string LastName = String.Empty;

        //Private readonly date time variable to determine the time 
        //TODO: Should it include read only in the declaration?
        private readonly DateTime Date;

        //Private variable to hold the customer's email address.
        private string EmailAddress = String.Empty;

        //Private variable to hold the customer's phone number.
        private string PhoneNumber = String.Empty;




        /// <summary>
        /// Default Constructor - creates a new customer obj.
        /// </summary>
        public CustomerClass()
        {
            Count += 1; 
            Id = Count;

        }

        /// <summary>
        /// Parameterized Constructor - creates a new obj based on the parameters being passed. 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="emailAddress"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="contactStatus"></param>
        public CustomerClass(bool contactStatus, string firstName, string lastName, DateTime date, string emailAddress, string phoneNumber) : this()
        {
            //The ": this()" above calls the default constructor where the the count and id are set.

            // Set the private variables declared within the class to the values being passed to the constructor.
            ContactStatus = contactStatus;
            FirstName = firstName;
            LastName = lastName;
            Date = date;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            
        }

        /// <summary>
        /// Get for the read-only static Count property value. 
        /// </summary>
        public int CustomerCount
        {
            get
            {
                return Count;
            }
        }

        /// <summary>
        /// Get for the read-only Id property value. 
        /// </summary>
        public int CustomerId
        {
            get
            {
                return Id;
            }
        }

        /// <summary>
        /// Gets and sets the value of the ContactStatus Property
        /// </summary>
        public bool CustomerContactStatus { get => ContactStatus; set => ContactStatus = value; }

        /// <summary>
        /// Gets and sets the value of the FirstName Property
        /// </summary>
        public string CustomerFirstName { get => FirstName; set => FirstName = value; }

        /// <summary>
        /// Gets and sets the value of the LastName Property
        /// </summary>
        public string CustomerLastName { get => LastName; set => LastName = value; }

        /// <summary>
        /// Gets the value of the date Property
        /// </summary>
        public string EnteredDate => Date.ToString();

        /// <summary>
        /// Gets and sets the value of the EmailAddress Property
        /// </summary>
        public string CustomerEmailAddress { get => EmailAddress; set => EmailAddress = value; }

        /// <summary>
        /// Gets and sets the value of the PhoneNumber Property
        /// </summary>
        public string CustomerPhoneNumber { get => PhoneNumber; set => PhoneNumber = value; }

        /// <summary>
        /// GetStatus is a function that shows the status of a customer obj. It returns a string that displays the value of the customer properties including if the customer 
        /// was contacted or not.
        /// </summary>
        /// <returns></returns>
        public string GetStatus()
        {
            //This string uses an inline if shortcut that will change the message according to the value of ContactStatus.
            return FirstName + " " + LastName + " (" + EmailAddress + " / " + PhoneNumber + ") " + " from " + Date + " " + (ContactStatus ? "has been contacted" : "has not been contacted");
        }
    }
}
