﻿namespace nat.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int GroupId { get; set; }// один ко многим
        public Group Group { get; set; } //навигационное свойство
    }
}
