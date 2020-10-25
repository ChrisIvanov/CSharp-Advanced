namespace ClassroomProject
{
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            Classroom classroom = new Classroom(5);

            Student studentOne = new Student("Pesho", "Peshov", "Art");
            Student studentTwo = new Student("Pesho", "Goshov", "Art");
            
            classroom.RegisterStudent(studentOne);
            classroom.RegisterStudent(studentTwo);

            Console.WriteLine(classroom.GetStudentsCount());

            Student studentThree = new Student("Kristian", "Ivanov", "Art");
            Student studentFour = new Student("Ivan", "Ivanov", "Art");

            Console.WriteLine(classroom.RegisterStudent(studentThree));
            Console.WriteLine(classroom.RegisterStudent(studentFour));
            

            Console.WriteLine(classroom.GetStudent("Kristian", "Ivanov"));
            Console.WriteLine(classroom.GetStudent("Ivan", "Ivanov"));

            Console.WriteLine(classroom.GetStudentsCount());


            Console.WriteLine(classroom.DismissStudent("Pesho", "Goshov"));

            Console.WriteLine(classroom.Count);

            Console.WriteLine(classroom.GetSubjectInfo("Art")); 

        }
    }
}