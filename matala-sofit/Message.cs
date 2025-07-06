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
        internal MessageType type{ get; set; }
        internal string text { get; set; }
        internal DateTime timestamp { get; set; }
        public Message(MessageType type, params object[] args)
        {
            this.type = type;
            this.timestamp = DateTime.Now;

            if(MessageTemplate.Templates.TryGetValue(type, out string template)) //ask about this
            {
                this.text = string.Format(template, args);
            }
            else
            {
                this.text = "there is no template for this type";
            }


        }
        public override bool Equals(object obj)
        {
            if (obj is Message other)
            {
                return this.type == other.type &&
                       this.text == other.text &&
                       this.timestamp == other.timestamp;
            }
            return false;
        }

        public override string ToString()
        {
            return $" {text} [{timestamp:yyyy-MM-dd HH:mm}]";
        }
    }
}
