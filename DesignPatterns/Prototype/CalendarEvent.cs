using System;

namespace Prototype
{
    public class CalendarEvent : CalendarPrototype
    {
        public Attendee[] Attendees { get; set; }
        public Priority Priority { get; set; }
        public DateTime StartDateAndTime { get; set; }

        public override CalendarPrototype Clone()
        {
            var copy = (CalendarEvent)base.Clone();

            // this allows us have another list, but same attendees there
            var copiedAttendees = (Attendee[])Attendees.Clone();
            copy.Attendees = copiedAttendees;

            // we also would like to copy priority
            copy.Priority = (Priority)Priority.Clone();

            return copy;
        }
    }
}