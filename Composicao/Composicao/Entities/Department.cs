﻿using System;

namespace Composicao.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        public Department() 
        {
        }
        public Department(string name)
        {
            Name = name;
        }
    }
}