using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bai1.Models
{
    public enum Gender
    {
        Female, Male
    }
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Điền tên vào")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Giới tính đâu")]
        public Gender Gender { get; set; }
        [DisplayName("Date of Birth")]
        [Required(ErrorMessage = "Ngày sinh?")]
        public DateTime Dob {  get; set; }
        [DisplayName("Batch Time")]
        [Required(ErrorMessage = "Điền cẩn thận vào")]
        public DateTime BatchTime {  get; set; }
        [Required(ErrorMessage = "Cho xin số")]
        [DisplayName("Phone Number")]
        public string PhoneNumber {  get; set; }
        [Required(ErrorMessage = "Cả mail luôn")]
        [DisplayName("Email Address")]
        public string EmailAddress {  get; set; }
        [Required(ErrorMessage = "Cái này nữa")]
        [DisplayName("Website Url")]
        public string WebsiteUrl {  get; set; }
        [Required(ErrorMessage = "Nốt đi")]
        public string Password {  get; set; }
        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Cái cuối")]
        public string ConfirmPass { get; set; }

    }
}
