using ViewModelCoreMVC.Models;

namespace ViewModelCoreMVC.ViewModels
{
    public class EmployeeDetails
    {
        public Employee? Employee { get; set; }
        public Department? Department { get; set; }
        public string? Title {  get; set; }
        public string? Header {  get; set; }
    }
}
