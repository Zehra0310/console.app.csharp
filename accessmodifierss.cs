using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
   public class Student
    {
        private int Id;
        private string Name;
        private string Surname;
        private DateTime Birthdate;

        public void SetName(string Name)
        {
            if (Name[0] == 'Z')
            {
                this.Name = Name;

            }
            else
            {
                this.Name ="Amina";
            }
        }
        public string GetName()
        {
            if (this.Name.Length < 6)
            {
                return this.Name;
            }
            return "Invalid";
        }
        public void Display()
        {
            Console.WriteLine("{0}. {1} {2} - {3}", this.Id, this.GetName(), this.Surname, this.Birthdate);
        }
    }

}