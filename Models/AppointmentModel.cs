using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppointmentMaker.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(20,MinimumLength =4)]
        [DisplayName("Patiant's full name")]
        public string PatiantName { get; set; }
        [DisplayName("Appointment Request Date")]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }
        [DisplayName("Patiant Approximate Net Worth")]
        [DataType(DataType.Currency)]
        public decimal PatiantNetWorth { get; set; }
        [DisplayName("Primary Doctor's Last Name")]
        public string DoctorName { get; set; }
        [DisplayName("Patient's Perceived Level of Pain (1 low to 10 high)")]
        [Range(1,10)]
        public int PainLevel { get; set; }
    }
}
