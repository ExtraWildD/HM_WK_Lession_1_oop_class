using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap_Dev_L_1
{
    public class Man : Person
    {
        public Man(string name) : base(name) 
        { 

        }

        public Man(string name, DateTime birthDay) : base(name, birthDay)
        {
        }

        protected override string HelloPhrase => "Привет, я - мужчина!";

        public bool HasBeard
        {
            get; private set;
        } = true;

        public void Shave()
        {
            Console.WriteLine("Бреется");
            this.HasBeard = false;
        }

        public override void SayHello()
        {
            Console.WriteLine("Привет! Я - мужчина.");
        }

        
    }
}
