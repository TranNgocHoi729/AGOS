using System;
using System.Collections.Generic;
using AGOS.ObjectToProperty;


namespace TestConmand
{
    class Program
    {
        static void Main(string[] args)
        {

            AGOS_Convert Agos = new AGOS_Convert_Handle();
        }
    }

    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public DateTime Dob { get; set; }
    }
}
