using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace matala_sofit
{
    public class Message
    {
        public MessageType Type { get; set; }
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }
        //change to not restart on each restart and also another ctor
        public Message(MessageType type, params object[] args)
        {
            this.Type = type;
            this.Timestamp = DateTime.Now;

            if (MessageTemplate.Templates.TryGetValue(type, out string template)) //ask about this
            {
                this.Text = string.Format(template, args);
            }
            else
            {
                this.Text = "there is no template for this type";
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Message other)
            {
                return this.Type == other.Type &&
                       this.Text == other.Text &&
                       this.Timestamp == other.Timestamp;
            }
            return false;
        }

        public override string ToString()
        {
            return $" {Text} [{Timestamp:yyyy-MM-dd HH:mm}]";
        }
    }
}
