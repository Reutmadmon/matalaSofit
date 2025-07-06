using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matala_sofit
{
    public abstract class Person
    {
        internal string name {  get; set; }
        internal string LastName { get; set; }
        internal int id { get; set; }
        internal string password { get; set; }
        internal int age { get; set; }
        internal int phoneNum { get; set; }
        internal string email { get; set; }
        internal string photo { get; set; }
        internal List<Message> messages { get; set; } = new List<Message>();

        public Person(string name, string lastName, int id, string password, int age, int phoneNum, string email, string photo)
        {
            this.password = password;
            this.name = name;
            this.LastName = lastName;
            this.id = id;
            this.age = age;
            this.phoneNum = phoneNum;
            this.email = email;
            this.photo = photo;
        }
        public void addMessage(Message message)
        {
            messages.Add(message);
        }
        public void removeMessage(Message message)
        {
            if (messages.Contains(message))
            {
                messages.Remove(message);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Person other)
                return this.id == other.id;
            return false;
        }

        public override String ToString()
        {
            string allMessage= (messages != null && messages.Count>0) 
                ? string.Join("\n", messages.Select(m => m.ToString()))
                :"no  messages";

            return $"Name: {name} {LastName}\n" +
                $"ID: {id}\n" +
                $"Age: {age}\n" +
                $"Phone Number: {phoneNum}\n" +
                $"Email: {email}\n" +
                $"Photo: {photo}\n" +
                $"Messages: {allMessage}";

        }
        //        {string.Join(", ", messages ?? new string[] { })}
     
    }
}
