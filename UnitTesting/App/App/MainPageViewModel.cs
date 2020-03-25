using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace App
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        string mail;
        string password;
        string phoneNumber;
        string address;
        string age;

        string phoneNumberOutput;
        string addressOutput;
        string ageOutput;

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
        public Command SignIn { get; set; }
    }
}
