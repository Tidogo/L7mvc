//tinfo200:[2020-03-12-tgoddard-dykstra1] -- creation of Enrollment class to be used in overall construction and logic of the Contoso University Project

namespace ContosoUniversity.Models
{
    //tinfo200:[2020-03-12-tgoddard-dykstra1] -- Grades are on a range of A-F not including E
    public enum Grade
    {
        A, B, C, D, F
    }

    //tinfo200:[2020-03-12-tgoddard-dykstra1] -- Enrollment has a many-to-one relationship to both Student and Course classes
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        //tinfo200:[2020-03-12-tgoddard-dykstra1] -- grade is a property that can be null, hence the "?"
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}