using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05_OOP_Interface
{
    internal class IMAXTicket : Ticket , Iprintable , Icloneable
    {
        public IMAXTicket(string movieName, decimal price, bool is3D) : base(movieName, is3D ? price + 30 : price)
        {
            Is3D = is3D;
        }

        public bool Is3D { get; set; }


        public override string ToString()
        {
            Console.WriteLine("=================Ticket Info=================");
            return $"Ticket ID : {_Id} | Movie Name : {_MovieName}  | Price : {Price} | Is3D : {Is3D} ";
        }

        //public override string PrintTicket()
        //{
        //    return $"Ticket ID : {_Id} | Movie Name : {_MovieName}  | Price : {Price} | Is3D : {Is3D} ";
        //}

        //       PRINT BY INTERFASE

        public override void print()
        {
            string Status = IsBooked ? "Booked" : "canseled";
            Console.WriteLine($"Ticket ID : {_Id} | Movie Name : {_MovieName}  | Price : {Price} | Is3D : {Is3D} | Status : {Status} ");
        }

        public IMAXTicket clone()
        {
            return new IMAXTicket(_MovieName , Price , Is3D);
        }
    }
}
