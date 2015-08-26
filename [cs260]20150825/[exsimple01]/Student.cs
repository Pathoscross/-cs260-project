using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _exsimple01_
{
    internal class Student
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string phone { get; set; }

        public void Getdata()
        {
            Console.Write("Enter Your Name :");
            this.Name = Console.ReadLine();
            Console.Write("Enter Your Email :");
            this.Email = Console.ReadLine();
            Console.Write("Enter Your Phone :");
            this.phone = Console.ReadLine();
        }

        public void ShowData()
        {
            string data = string.Format("姓名: {0}\nEmail: {1}\nPhone: {2}", this.Name, this.Email, this.Email);
            Console.WriteLine(data);
        }
    }
}