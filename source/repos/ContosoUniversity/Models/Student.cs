//tinfo200:[2020-03-12-tgoddard-dykstra1] -- creation of Student class to be used in overall construction and logic of the Contoso University Project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //tinfo200:[2020-03-12-tgoddard-dykstra1] -- since student<->enrollment is a one-to-many relationship, one student may have many enrolmments. The specific enrollments for a particular student will be stored in this collection property
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
