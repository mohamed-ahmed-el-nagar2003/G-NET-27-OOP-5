using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05_OOP_Interface
{
    internal class StandardTicket : Ticket , Iprintable , Icloneable
    {

        public string _SeatNumber { get; set; }

        public StandardTicket(string seatNumber, string movieName, decimal price) : base(movieName, price)
        {
            _SeatNumber = seatNumber;
        }

        public override string ToString()
        {
            Console.WriteLine("=================Ticket Info=================");
            return $"Ticket ID : {_Id} | Movie Name : {_MovieName}  | Price : {Price} | Seat Number : {_SeatNumber}";
        }

        //public override string PrintTicket()
        //{
        //    return $"Ticket ID : {_Id} | Movie Name : {_MovieName}  | Price : {Price} | Seat Number : {_SeatNumber}";
        //}

        //       PRINT BY INTERFASE
        public override void print()
        {
            string Status = IsBooked ? "Booked" : "canseled";
            Console.WriteLine($"Ticket ID : {_Id} | Movie Name : {_MovieName}  | Price : {Price} | Seat Number : {_SeatNumber} | Status : {Status}");
        }
        public StandardTicket clone()
        {
            return new StandardTicket(_SeatNumber , _MovieName , Price);
        }
    }
}
