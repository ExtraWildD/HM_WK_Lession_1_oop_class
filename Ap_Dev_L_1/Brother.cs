using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap_Dev_L_1
{
    public class Brother : Person
    {
        public Brother(string name) : base(name)
        {

        }

        public Brother(string name, DateTime birthDay) : base(name, birthDay)
        {
        }

        protected override string HelloPhrase => "Привет, я - Brother!";

        public bool HasBeard
        {
            get; private set;
        } = true;

        public bool Training { get; set; } = false;

        public void Shave()
        {
            Console.WriteLine("Бреется");
            this.HasBeard = false;
        }

        public override void SayHello()
        {
            Console.WriteLine("Привет! Я - брат Олега");
        }

        public void HelpWithTraining()
        {
            Console.WriteLine("Помогаю брату на силовых тренировках");
            this.Training = true;
        }

    }
}
