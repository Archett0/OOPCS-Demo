namespace OOPCS
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Person person1 = new("Jack");
            // person1.Eat();
            // person1.Talk();
            // person1.Sleep();
            //
            // LED led = new LED("RED");
            // Console.WriteLine(led.GetColor());
            // led.IsLEDOn();
            // led.TurnOn();
            // led.IsLEDOn();
            // led.TurnOff();
            // led.IsLEDOn();

            // date11 date = new date11(11, 7, 2022);
            // date.Month = 8;
            // var day = date.Day;
            // date.PrintDateDetails();

            // Employee employee = new Employee("Jack", "Male", 30, 1.7, 121, "Mail001");
            // employee.PrintDetails();

            var manager = new Manager("IT Department");
            manager.PrintDetails();
        }
    }
}
