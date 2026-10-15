namespace CSharpCanvas
{
    public class Course
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public Student[] RegisteredStudents { get; set; }
        public int RegistrationLimit { get; set; }
        private int numRegistered = 0;

        public Course(string name, string teacher, int registrationLimit)
        {
            Name = name;
            Teacher = teacher;
            RegistrationLimit = registrationLimit;

            // create the empty registration list
            RegisteredStudents = new Student[RegistrationLimit];
        }

        // actions (METHODS)
        public void RegisterStudent(Student person)
        {
            RegisteredStudents[numRegistered] = person;
            numRegistered++;
        }
    }
}
