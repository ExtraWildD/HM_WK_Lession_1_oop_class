using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap_Dev_L_1
{
    public class Person
    {
        public readonly string Name = String.Empty;
        public readonly DateTime Birthday;
        protected virtual string HelloPhrase { get; set; } = "Привет, я - человек!";
        public Person Father = null;
        public Person Mother = null;
        public Person[] Children = null;


        public Person(string name, DateTime birthDay)
        {
            this.Name = name;
            if (birthDay <= DateTime.Now)
                this.Birthday = birthDay;
            else
            {
                Console.WriteLine("Дата не верна!Присваиваю сегодняшнюю");
                this.Birthday = DateTime.Now;
            }
            
        }

        public Person(string name)
        {
            this.Name = name;            
            this.Birthday = DateTime.Now;
            

        }


        public void Print()
        {
            Console.WriteLine($"Имя= {Name}, ДР {Birthday}");
        }

        public bool IsAdult(int adultAge = 18)
        {
            var delta = DateTime.Now.Year - this.Birthday.Year;
            if (delta > adultAge || (delta == adultAge && DateTime.Now.DayOfYear <= Birthday.DayOfYear))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddFamilyInfo(Person father, Person mother, params Person[] children)
        {
            Father = father;
            Mother = mother;
            Children = children;
        }

        public void PrintFamilyInfo()
        {
            if (Father != null)
            {
                Console.WriteLine("Отец: ");
                Father.Print();
            }
            if (Mother != null)
            {
                Console.WriteLine("Мать: ");
                Mother.Print();
            }
            if (Children != null && Children.Length > 0)
            {
                Console.WriteLine("Дети: ");
                foreach (var child in Children)
                {
                    child.Print();
                }

            }
        }

        public bool GetChildren(out Person[] children)
        {
            if (Children != null && Children.Length > 0)
            {
                children = Children;
                return true;
            }
            else
            {
                children = null;
                return true;
            }
        }

        public virtual void SayHello()
        {
            Console.WriteLine("Привет! Я - человек.");
        }

        public void SayHelloPhrase()
        {
            Console.WriteLine(this.HelloPhrase);
        }

        public class AdultAge
        {
            private int age;

            public int Age
            {
                get { return age; }
                set
                {
                    if (value < 18)
                    {
                        age = 18;
                    }
                    else
                    {
                        age = value;
                    }
                }
            }
        }

        public class DataClass
        {
            public required int te;
        }


    }
}
