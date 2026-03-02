using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_PolyMorphism
{
    internal class IMAXTicket : Ticket
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

        public override string PrintTicket()
        {
            return $"Ticket ID : {_Id} | Movie Name : {_MovieName}  | Price : {Price} | Is3D : {Is3D} ";
        }

    }
}
