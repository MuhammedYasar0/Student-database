using System;
using System.ComponentModel.DataAnnotations;

namespace StudentDatabase
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string StudentNumber { get; set; }
    }
} 