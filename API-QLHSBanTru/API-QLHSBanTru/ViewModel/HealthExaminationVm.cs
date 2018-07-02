using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class HealthExaminationVm
    {
        public int HealthExaminationID { get; set; }
        public System.DateTime Date { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public bool Height { get; set; }
        public bool Weight { get; set; }
        public bool Eyes { get; set; }
        public bool ENT { get; set; }
        public bool InternalMedicine { get; set; }
        public bool Oral { get; set; }
        public bool Surgery { get; set; }
        public bool Dermatology { get; set; }
        public bool BoneMuscle { get; set; }
        public bool Nerve { get; set; }
        public bool Endocrine { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<HealthExaminationDetailVm> HealthExaminationDetails { get; set; }
    }
}