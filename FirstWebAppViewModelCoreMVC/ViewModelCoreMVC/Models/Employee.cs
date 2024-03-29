﻿namespace ViewModelCoreMVC.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; } = default;
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone {  get; set; }
        public double? Salary { get; set; }
    }
}
