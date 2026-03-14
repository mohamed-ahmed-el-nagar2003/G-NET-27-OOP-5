using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05_OOP_Interface
{
    internal class Cinema : Iprintable
    {
        public string CinemaName { get; set; }

        private Projector Projector = new Projector();

        public Ticket[] reservation = new Ticket[20];

     

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

                    reservation[i].print();
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

        public void print()
        {
            for (int i = 0; i < reservation.Length; i++)
            {

                if (reservation[i] != null)
                {

                    reservation[i].print();
                }



            }
        }
    }
}
