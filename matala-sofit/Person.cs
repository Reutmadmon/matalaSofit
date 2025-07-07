using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace matala_sofit
{
    public abstract class Person
    {
        private string _name;
        private string _lastName;
        private int _id;
        private string _password;
        private int _phoneNum;
        private string _email;
        private string _photo;

        public string Name
        {
            get => _name;
            set
            {
                if (!Regex.IsMatch(value, @"^[a-zA-Z\u0590-\u05FF\s]+$"))
                    throw new Exception("Name must contain only letters and spaces.");
                _name = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (!Regex.IsMatch(value, @"^[a-zA-Z\u0590-\u05FF\s]+$"))
                    throw new Exception("Last name must contain only letters and spaces.");
                _lastName = value;
            }
        }

        public int Id
        {
            get => _id;
            set
            {
                if (!Regex.IsMatch(value.ToString(), @"^\d{9}$"))
                    throw new Exception("ID must be exactly 9 digits.");
                if (IdOrPassExists(value.ToString(), "passwords.txt", "id"))
                    throw new Exception("ID already exists.");
                _id = value;
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (!Regex.IsMatch(value, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"))
                    throw new Exception("Password must be at least 8 characters and contain upper, lower, and digit.");
                if (IdOrPassExists(value, "passwords.txt", "password"))
                    throw new Exception("Password already exists.");
                _password = value;
            }
        }


        public int PhoneNum
        {
            get => _phoneNum;
            set
            {
                if (!Regex.IsMatch(value.ToString(), @"^05\d{8}$"))
                    throw new Exception("Phone number must start with 05 and be 10 digits.");
                _phoneNum = value;
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (!Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    throw new Exception("Invalid email format.");
                _email = value;
            }
        }

        public string Photo
        {
            get => _photo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Photo path cannot be empty.");
                _photo = value;
            }
        }   

        public int Age { get; set; }
        public List<Message> Messages { get; set; } = new List<Message>();

        public Person(string name, string lastName, int id, string password, int age, int phoneNum, string email, string photo)
        {
            this.Password = password;//sets password first to ensure it is valid
            this.Name = name;
            this.LastName = lastName;
            this.Id = id;
            this.Age = age;
            this.PhoneNum = phoneNum;
            this.Email = email;
            this.Photo = photo;
        }

        public void AddMessage(Message message)
        {
            Messages.Add(message);
        }

        public void RemoveMessage(Message message)
        {
            if (Messages.Contains(message))
            {
                Messages.Remove(message);
            }
        }

        public static bool IdOrPassExists(string idToCheck, string filePath, string typeOfCheck)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (typeOfCheck.Equals("password"))
                    {
                        if (parts.Length > 0 && parts[1] == idToCheck)
                        {
                            return true; // password already exists
                        }
                    }
                    else if (typeOfCheck.Equals("id"))
                    {
                        if (parts.Length > 0 && parts[0] == idToCheck)
                        {
                            return true; // ID already exists
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }

            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj is Person other)
                return this.Id == other.Id;
            return false;
        }

        public override string ToString()
        {
            string allMessage = (Messages != null && Messages.Count > 0)
                ? string.Join("\n", Messages.Select(m => m.ToString()))
                : "no  messages";

            return $"Name: {Name} {LastName}\n" +
                $"ID: {Id}\n" +
                $"Age: {Age}\n" +
                $"Phone Number: {PhoneNum}\n" +
                $"Email: {Email}\n" +
                $"Photo: {Photo}\n" +
                $"Messages: {allMessage}";
        }
    }
}
