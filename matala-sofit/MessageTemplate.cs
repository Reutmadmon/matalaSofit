using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matala_sofit
{
    public class MessageTemplate
    {
        public static readonly Dictionary<MessageType, string> Templates = new Dictionary<MessageType, string>
    {
        { MessageType.BookDueSoon, "The book \"{0}\" is due in {1} days." },
        { MessageType.BookDueDate, "The book \"{0}\" is due on {1}." },
        { MessageType.OverdueBookNotice, "The book \"{0}\" is overdue!" },
        { MessageType.ReservationReady, "Your reserved book \"{0}\" is ready for pickup." },
        { MessageType.ShiftStarted, "Employee {0} has started their shift." },
        { MessageType.ShiftEnded, "Employee {0} has ended their shift." },
        { MessageType.TaskAssigned, "New task: {0}" },
        { MessageType.MeetingReminder, "Reminder: Meeting at {0}" }
    };
        //להוסיף גם על חובות והוספת ספר למערך עצמי ומועדפים
    }
}
