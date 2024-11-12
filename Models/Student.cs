using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace View_Component_Practice.Models
{
    public class Student
    {
        public static List<Student> GetStudentLists()
        {
            List<Student> students = new List<Student>
            {
                new Student {ID = 1, Name = "Rahim Khan", Age = 15, Email = "rahim@gmail.com", Phone = "01903081186"},
                new Student {ID = 2, Name = "Karim Ullah", Age = 16, Email = "karim@gmail.com", Phone = "01903081234"},
                new Student {ID = 3, Name = "Anika Chowdhury", Age = 15, Email = "anika@gmail.com", Phone = "01903083456"},
                new Student {ID = 4, Name = "Samiul Hasan", Age = 17, Email = "samiul@gmail.com", Phone = "01903082345"},
                new Student {ID = 5, Name = "Fatima Noor", Age = 16, Email = "fatima@gmail.com", Phone = "01903084567"},
                new Student {ID = 6, Name = "Naimul Islam", Age = 15, Email = "naimul@gmail.com", Phone = "01903086789"},
                new Student {ID = 7, Name = "Tanvir Hossain", Age = 16, Email = "tanvir@gmail.com", Phone = "01903089012"},
                new Student {ID = 8, Name = "Mim Akter", Age = 17, Email = "mim@gmail.com", Phone = "01903087654"},
                new Student {ID = 9, Name = "Rifat Hasan", Age = 15, Email = "rifat@gmail.com", Phone = "01903080987"},
                new Student {ID = 10, Name = "Lamia Sultana", Age = 16, Email = "lamia@gmail.com", Phone = "01903083478"}
            };
            return students;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}