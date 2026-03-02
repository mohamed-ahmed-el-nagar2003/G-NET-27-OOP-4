using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_PolyMorphism
{
    internal class StandardTicket : Ticket
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

        public override string PrintTicket()
        {
            return $"Ticket ID : {_Id} | Movie Name : {_MovieName}  | Price : {Price} | Seat Number : {_SeatNumber}";
        }

    }
}
