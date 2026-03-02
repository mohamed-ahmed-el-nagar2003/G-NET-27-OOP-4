using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_PolyMorphism
{
    internal class VipTicket : Ticket
    {
        public bool _LoungeAccess;
        public decimal ServiceFee = 50;

        public VipTicket(bool loungeAccess, string movieName, decimal price) : base(movieName, price + 50)
        {
            _LoungeAccess = loungeAccess;
        }

        public override string ToString()
        {
            Console.WriteLine("=================Ticket Info=================");
            return $"Ticket ID : {_Id} | Movie Name : {_MovieName}  | Price : {Price} | ServiceFee : {ServiceFee} | LoungeAccess : {_LoungeAccess}";
        }

        public override string PrintTicket()
        {
            return $"Ticket ID : {_Id} | Movie Name : {_MovieName}  | Price : {Price} | ServiceFee : {ServiceFee} | LoungeAccess : {_LoungeAccess}";
        }
    }
}
