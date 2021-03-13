//tinfo200:[2020-03-12-tgoddard-dykstra1] -- creation of the initial course class which interacts with student and enrollment classes and is essential for the operation of the overall project

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {

        //tinfo200:[2020-03-12-tgoddard-dykstra1] -- specifies that the primary key can be generated on this end and not by the database itself
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        //tinfo200:[2020-03-12-tgoddard-dykstra1] -- course has a one-to-many relationship to enrollments and has a property of enrollments stored as a collection
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}