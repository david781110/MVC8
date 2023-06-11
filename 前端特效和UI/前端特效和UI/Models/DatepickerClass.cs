using System.ComponentModel.DataAnnotations;

namespace 前端特效和UI.Models
{
    public class DatepickerClass
    {
        public int MyID { get; set; }
        public string MyName { get; set; }
        [DataType(DataType.Date)]
        public DateTime MyBirthDay { get; set; }

        public bool? MyDropList { get; set; }

        public bool MyApprove { get; set; }

    }
}
