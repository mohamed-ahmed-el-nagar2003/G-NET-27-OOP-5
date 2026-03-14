using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05_OOP_Interface
{
    internal class Ticket: Icloneable , Iprintable
    {

        public bool IsBooked { get;private set; }  = true;
        // Book the ticket
        public bool Book()
        {
            if (!IsBooked)
            {
                Console.WriteLine($"Ticket for {_MovieName}  booked successfully.");
                IsBooked = true;
                return true;
            }
           
            Console.WriteLine($"Ticket for {_MovieName}   is already booked.");
            return false;
        }

        public bool Cansel()
        {
            if (IsBooked)
            {
                Console.WriteLine($"Ticket for {_MovieName}  cancelled successfully.");
                IsBooked = false;
                return true;
            }
            Console.WriteLine($"Ticket for {_MovieName}  is not booked, cannot cancel.");
            return false;


        }

        public string _MovieName { get; set; }

        private decimal _Price;
        public decimal Price
        {
            get
            {
                return _Price;
            }
            set
            {
                if (0 < value)
                    _Price = value;
                else
                    throw new ArgumentException("Price must be > 0");
            }
        }

        public int _Id { get; }

        private static int counter = 0;

        public Ticket(string movieName, decimal price)
        {
            _MovieName = movieName;
            _Price = price;
            counter++;
            _Id = counter;
        }

        public decimal PriceAfterTax => _Price + (_Price * .14m);

        public override string ToString()
        {
            Console.WriteLine("=================Ticket Info=================");
            return $"Ticket ID : {_Id} | Movie Name : {_Price}  | Price : {_Price} ";
        }

        public static int GetTotalTickets()
        {
            return counter;
        }
        //           PRINT TICKET
        //public virtual string PrintTicket()
        //{
        //    string Status = IsBooked ? "Booked" : "canseled";
        //    return $"Ticket ID : {_Id} | Movie Name : {_Price}  | Price : {_Price} | Status : {Status}";
        //}

        //             SET PRICE WITH One Params
        public void SetPrice(decimal price)
        {
            Price = price;
        }
        //             SET PRICE WITH  2 Params
        public void SetPrice(decimal price, decimal multiplier)
        {
            Price = price * multiplier;
        }

        public virtual Ticket clone()
        {
            return new Ticket(_MovieName , _Price);
        }

        public virtual void  print()
        {
            string Status = IsBooked ? "Booked" : "canseled";
            Console.WriteLine( $"Ticket ID : {_Id} | Movie Name : {_Price}  | Price : {_Price} | Status : {Status}" );
        }
    }
}
