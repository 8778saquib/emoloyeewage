using System;
namespace emp_wage1
{
    public class empcal
    {
        int hour = 8;
        int rateperhour = 20;
        int salary;

        bool present;


        public void checkingpresentORAbsent()

        {
            Random value = new Random();
            int empCheck = value.Next(0, 2);


            if (empCheck == 1)
            {
                present = true;
                
                Console.WriteLine("Employee is present");


            }
            else
            {
                present = false;
                Console.WriteLine("Employee is Absent");
            }
        }
        public void caldailywage()
        {

            if (present)
            {
                salary = hour * rateperhour;
                Console.WriteLine("daily wage is {0}", salary);
            }
        }



    }
}


    






