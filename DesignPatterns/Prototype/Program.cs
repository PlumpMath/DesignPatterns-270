using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class PrototypeDemo
    {
        public static CalendarEvent GetExistingEvent()
        {
            var beerParty = new CalendarEvent();
            var friends = new Attendee[1];
            var andriy = new Attendee { FirstName = "Andriy", LastName = "Buday" };
            friends[0] = andriy;
            beerParty.Attendees = friends;
            beerParty.StartDateAndTime = new DateTime(2010, 7, 23, 19, 0, 0);
            beerParty.Priority = Priority.High();

            return beerParty;
        }

        public static void Main()
        {
            var beerParty = GetExistingEvent();
            var nextFridayEvent = (CalendarEvent)beerParty.Clone();
            nextFridayEvent.StartDateAndTime = new DateTime(2010, 7, 30, 19, 0, 0);

            // про цей код побалакаємо трішки нижче
            nextFridayEvent.Attendees[0].EmailAddress = "andriybuday@liamg.com";
            nextFridayEvent.Priority.SetPriorityValue(0);

            if (beerParty.Attendees != nextFridayEvent.Attendees)
            {
                Console.WriteLine("GOOD: Each event has own list of attendees.");
            }
            if (beerParty.Attendees[0].EmailAddress == nextFridayEvent.Attendees[0].EmailAddress)
            {
                //В цьому випадку добре мати поверхневу копію кожного із учасників
                //таким чином моя адреса, ім'я і персональні дані залишаються тими ж
                Console.WriteLine("GOOD: If I updated my e-mail address it will be updated in all events.");
            }
            if (beerParty.Priority.IsHigh() != nextFridayEvent.Priority.IsHigh())
            {
                Console.WriteLine("GOOD: Each event should have own priority object, fully-copied.");
            }
        }
    }


}
