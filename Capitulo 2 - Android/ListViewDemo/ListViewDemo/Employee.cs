using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListViewDemo
{
    public class Employee
    {
        public override string ToString()
        {
            return Name;
        }
        private string name;

        public string Name { get; set; }

        private string position;

        public string Position { get; set; }

        private string email;

        public string Email { get; set; }

        public Employee(string name, string position, string email)
        {
            Name = name;
            Position = position;
            Email = email;
        }
    }
}