namespace StudentWeb.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime AdmissionDate { get; set; }
        public int AdmissionFees { get; set; }
        public string status { get; set; }
    }
}
