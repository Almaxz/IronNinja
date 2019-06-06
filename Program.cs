using System;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet Chicking = new Buffet();
            SweetTooth l = new SweetTooth("Leo");
            SpiceHound rj = new SpiceHound("RJ");
            while(!l.IsFull)
            {
                l.Consume(Chicking.Serve());
            }
            l.Consume(Chicking.Serve());
            Console.WriteLine("\n=============================================================================================================================\n");
            while(!rj.IsFull)
            {
                rj.Consume(Chicking.Serve());
            }
            rj.Consume(Chicking.Serve());
        }
    }
}
