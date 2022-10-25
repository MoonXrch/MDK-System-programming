using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MDK.Lab7
{
    class Student:Person
    {
        public Student(string name, int age, string gender, string myGroup, string vuz, string special)
        {
            Name = name;
            Age = age;
            Gender = gender;
            MyGroup = myGroup;
            Vuz = vuz;
            Special = special;

        }
        // переменные
        private string _group = " ";
        private string _vuz = " ";
        private string _special = " ";
        // свойства
        public string MyGroup
        {
            get
            {
                return _group;
            }
            set
            {
                _group = value;
            }
        }
        public string Vuz
        {
            get
            {
                return _vuz;
            }
            set
            {
                _vuz = value;
            }
        }
        public string Special
        {
            get
            {
                return _special;
            }
            set
            {
                _special = value;
            }
        }
    }
}
