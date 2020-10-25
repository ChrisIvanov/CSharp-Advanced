using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;

        private int capacity;
        public Classroom(int capacity)
        {
            students = new List<Student>();
            Capacity = capacity;
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public int Count
        {
            get
            {
                return students.Count;
            }
            set
            {
                Count = value;
            }

        }

        public string RegisterStudent(Student student)
        {
            if (capacity > this.students.Count)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {

            Student student = this.students.Find(x => x.FirstName == firstName && x.LastName == lastName);
            if (this.students.Contains(student))
            {
                this.students.Remove(student);
                return $"Dismissed student {student.FirstName} {student.LastName}";
            }


            return $"Student not found";
        }

        public string GetSubjectInfo(string subject)
        {
            List<Student> bySubject = this.students.FindAll(x => x.Subject == subject).ToList();

            if (bySubject.Count > 0)
            {
                string subjectInfo = String.Empty;
                  subjectInfo += ($"Subject: {subject}\nStudent:");

                foreach (var student in bySubject)
                {
                    subjectInfo += ($"\n{student.FirstName} {student.LastName}");
                }
                return subjectInfo;
            }

            return "No students enrolled for the subject";

        }

        public int GetStudentsCount()
        {
            return this.students.Count;
        }

        public string GetStudent(string firstName, string lastName)
        {
            Student student = this.students.Find(x => x.FirstName == firstName && x.LastName == lastName);

            return student.ToString();
        }
    }
}
