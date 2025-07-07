using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matala_sofit
{
        public enum MessageType
        {
            BookDueSoon,
            BookDueDate,//this one
            OverdueBookNotice,
            ReservationReady,
            ShiftStarted,
            ShiftEnded,
            TaskAssigned,
            MeetingReminder
        }
}

