using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace App
{
    /// <summary>
    /// View Model class for Main Page. Created in compliance with the MVVM standard.
    /// </summary>
    public class MainPageViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// MainPageViewModel class fields.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        string mail;
        string password;
        string phoneNumber;
        string address;
        string age;

        string phoneNumberOutput;
        string addressOutput;
        string ageOutput;

        /// <summary>
        /// MainPageViewModel constructor with SignIn lambda function.
        /// </summary>
        public MainPageViewModel()
        {
            SignIn = new Command(() =>
            {
                User user = new User(Mail, Password, PhoneNumber, Address, Age);
                PhoneNumberOutput = user.PhoneNumber == "" ? "424-242-424" : user.PhoneNumber;
                AddressOutput = user.Address == "" ? "Kwiatowa 13" : user.Address;
                AgeOutput = user.Age == "" ? "42" : user.Age;
            });
        }
        /// <summary>
        /// Mail property for handling input - mail given by user.
        /// </summary>
        public string Mail
        {
            get => mail;
            set
            {
                mail = value;
                var args = new PropertyChangedEventArgs(nameof(Mail));
                PropertyChanged?.Invoke(this, args);
            }
        }
        /// <summary>
        /// Password property for handling input - password given by user.
        /// </summary>
        public string Password
        {
            get => password;
            set
            {
                password = value;
                var args = new PropertyChangedEventArgs(nameof(Password));
                PropertyChanged?.Invoke(this, args);
            }
        }
        /// <summary>
        /// PhoneNumber property for handling input - phone number given by user.
        /// </summary>
        public string PhoneNumber
        {
            get
                => phoneNumber;
            set
            {
                phoneNumber = value;
                var args = new PropertyChangedEventArgs(nameof(PhoneNumber));
                PropertyChanged?.Invoke(this, args);
            }
        }
        /// <summary>
        /// Address property for handling input - address given by user.
        /// </summary>
        public string Address
        {
            get
                => address;
            set
            {
                address = value;
                var args = new PropertyChangedEventArgs(nameof(Address));
                PropertyChanged?.Invoke(this, args);
            }
        }
        /// <summary>
        /// Age property for handling input - age given by user.
        /// </summary>
        public string Age
        {
            get
                => age;
            set
            {
                age = value;
                var args = new PropertyChangedEventArgs(nameof(Age));
                PropertyChanged?.Invoke(this, args);
            }
        }
        /// <summary>
        /// PhoneNumberOutput property for handling output - phone number used in the app.
        /// </summary>
        public string PhoneNumberOutput
        {
            get
                => phoneNumberOutput;
            set
            {
                phoneNumberOutput = value;
                var args = new PropertyChangedEventArgs(nameof(PhoneNumberOutput));
                PropertyChanged?.Invoke(this, args);
            }
        }
        /// <summary>
        /// AddressOutput property for handling output - user's adderess used in the app.
        /// </summary>
        public string AddressOutput
        {
            get
                => addressOutput;
            set
            {
                addressOutput = value;
                var args = new PropertyChangedEventArgs(nameof(AddressOutput));
                PropertyChanged?.Invoke(this, args);
            }
        }
        /// <summary>
        /// AgeOutput property for handling output - user's age saved in the app.
        /// </summary>
        public string AgeOutput
        {
            get
                => ageOutput;
            set
            {
                ageOutput = value;
                var args = new PropertyChangedEventArgs(nameof(AgeOutput));
                PropertyChanged?.Invoke(this, args);
            }
        }
        /// <summary>
        /// SignIn property used for creating mock users.
        /// </summary>
        public Command SignIn { get; set; }
    }
}
