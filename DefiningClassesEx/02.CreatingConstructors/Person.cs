﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {

        private string name;
        private int age;

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age) : this ()
        {
            Age = age;
        }

        public Person(string name, int age) : this (age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

    }
}
