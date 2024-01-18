using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap_Dev_L_1
{
    public class Woman : Person
    {
        protected override string HelloPhrase => "Привет, я женщина!";
        public bool HasMakeup
        {
            get; private set;
        } = false;
        public Woman(string name) : base(name)
        {

        }

        public Woman(string name, DateTime birthDay) : base(name, birthDay)
        {
        }

        public void PutMakeup()
        {
            Console.WriteLine("Наносит макияж");
            this.HasMakeup = true;
        }

        public void RemoveMakeup()
        {
            Console.WriteLine("Удаляет макияж");
            this.HasMakeup = false;
        }
        public override void SayHello()
        {
            Console.WriteLine("Привет! Я - женщина.");
        }
    }
}
