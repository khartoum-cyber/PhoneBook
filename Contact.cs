using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    public class Contact
    {
        private Contact(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public string Name { get; set; }
        public int Number { get; set; }
    }
}
