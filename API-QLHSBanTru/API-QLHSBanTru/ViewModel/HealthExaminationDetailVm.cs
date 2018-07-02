namespace API_QLHSBanTru.ViewModel
{
    public class HealthExaminationDetailVm
    {
        public int HealthExaminationDetailID { get; set; }
        public int HealthExaminationID { get; set; }
        public int StudentID { get; set; }
        public int HealthInsurance { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Eyes { get; set; }
        public string ENT { get; set; }
        public string InternalMedicine { get; set; }
        public string Oral { get; set; }
        public string Surgery { get; set; }
        public string Dermatology { get; set; }
        public string BoneMuscle { get; set; }
        public string Nerve { get; set; }
        public string Endocrine { get; set; }
        public string Other { get; set; }
        public string Note { get; set; }
        public double Rating { get; set; }
        public bool Status { get; set; }

        public virtual HealthExaminationVm HealthExamination { get; set; }
        public virtual StudentVm Student { get; set; }
    }
}