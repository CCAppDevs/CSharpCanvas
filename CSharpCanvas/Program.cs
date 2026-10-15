namespace CSharpCanvas
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public int Age; // remember this choice

        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int toast = 5; // stack declared

            Student[] students = new Student[] {
                new Student("Jesse", "Harlan", 44),
                new Student("Sarah", "Harlan", 40),
                new Student("Ashton", "Harlan", 10),
                new Student("Bob", "Jones", 18),
            };

            foreach (Student student in students)
            {
                Console.WriteLine($"Welcome to Centralia College, {student.FirstName}");
            }
        }
    }
}
