﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gym.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //[DataType("Data")]
        public DateTime BirthDate { get; set; }
        //[NotMapped]
        public int Age { get { return (DateTime.Now.Year - BirthDate.Year); } }
        public string NationalCode { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string? PhoneNumber { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Balance { get; set; }

    }
}

