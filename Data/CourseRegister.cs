using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class CourseRegister
    {
        [Key]
        public int CourseRegisterId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}