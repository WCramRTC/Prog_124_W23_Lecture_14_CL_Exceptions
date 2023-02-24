﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prog_124_W23_Lecture_14_CL_Exceptions
{
    class Team
    {
        string _name;
        static int count;

        public Team(string name)
        {
            _name = name;
            MessageBox.Show($"The {name} team object was just constructed");
            count++;
        }

        public string Name { get => _name; set => _name = value; }

        public override string ToString()
        {
            return $"{_name}";
        }

        // Destructor
        // Tilde - ~
        ~Team()
        {
            MessageBox.Show($"The {_name} object was just DECONSTRUCTED");
            count--;
        }
    }
}
