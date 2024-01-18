using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap_Dev_L_1
{
    public class Sister : Person
    {
        protected override string HelloPhrase => "Привет, я сестра!";
        public bool HasMakeup
        {
            get; private set;
        } = false;
        public Sister(string name) : base(name)
        {

        }

        public Sister(string name, DateTime birthDay) : base(name, birthDay)
        {
        }

        public void CanBeFun()
        {
            Console.WriteLine("Весело смеется");
            this.HasMakeup = true;
        }

        public void HelpsWithCleaning()
        {
            Console.WriteLine("Я помогаю с уборкой в квартире");
            this.HasMakeup = false;
        }
        public override void SayHello()
        {
            Console.WriteLine("Привет! Я - сестра Анны");
        }
    }
}
