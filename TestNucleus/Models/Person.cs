﻿using System;

namespace TestNucleus.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}