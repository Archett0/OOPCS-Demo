namespace OOPCS
{
    public class Program
    {
        public static void ChangeName(Student student)
        {
            Console.WriteLine();
            student.Name = "New Name";
            Console.WriteLine();
        }

        public static void RefDemo(ref int num)
        {
            num++;
        }

        static void Main(string[] args)
        {
            // Student student = new Student("Song");
            // Console.WriteLine("Before: " + student.Name);
            // ChangeName(student);
            // Console.WriteLine("After: " + student.Name);
            //
            int num = 0;
            Console.WriteLine(num);
            RefDemo(ref num);
            Console.WriteLine(num);
        }
    }
}
