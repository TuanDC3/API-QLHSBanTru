namespace API_QLHSBanTru.ViewModel
{
    public class StudentParentVm
    {
        public int StudentParentsID { get; set; }
        public int StudentID { get; set; }
        public string Password { get; set; }
        public string FatherName { get; set; }
        public System.DateTime FatherBirthday { get; set; }
        public string FatherPhone { get; set; }
        public string FatherJob { get; set; }
        public string MotherName { get; set; }
        public System.DateTime MotherBirthday { get; set; }
        public string MotherPhone { get; set; }
        public string MotherJob { get; set; }

        public virtual StudentVm Student { get; set; }
    }
}