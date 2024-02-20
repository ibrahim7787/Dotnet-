namespace ViewModelCoreMVC.Models
{
    public class Department
    {
        public int EmployeeId {  get; set; }
        public string? DepName {  get; set; }
        public string? DomainName {  get; set; }
        public DateOnly? JoinDate { get; set; }
    }
}
