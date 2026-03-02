using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_PolyMorphism
{
    internal class Cinema
    {
        public string CinemaName { get; set; }

        private Projector Projector = new Projector();

        private Ticket[] reservation = new Ticket[20];

        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;
        }

        public void AddTicket(Ticket t)
        {
            for (int i = 0; i < reservation.Length; i++)
            {
                if (reservation[i] == null)
                {
                    reservation[i] = t;
                    return;
                }

            }

            Console.WriteLine("Cinema is full. Cannot add more tickets.");
        }

        //       PRINT ALL TICKETS
        public void PrintallTickets()
        {
            for (int i = 0; i < reservation.Length; i++)
            {

                if (reservation[i] != null)
                {

                    Console.WriteLine($"{reservation[i].PrintTicket()}");
                }



            }
        }


        public void Opencinem()
        {
            Projector.turnOn();
        }

        public void CloseCinema()
        {
            Projector.turnOff();
        }
    }
}
