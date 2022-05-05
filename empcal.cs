using System;
namespace emp_wage1
{
    public class empcal
    {
        int hour = 8;
        int rateperhour = 20;
        int salary;
        int parttimerate = 8;
        int partsalary;
        bool present;
        bool parttime;
        Random value = new Random();


        public void checkingpresentORAbsent()

        {
            
            int empCheck = value.Next(0, 2);


            if (empCheck == 1)
            {
                present = true;
                
                Console.WriteLine(" full timeEmployee is present");


            }
            else
            {
                present = false;
                Console.WriteLine(" full timeEmployee is Absent");
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
        public void parttimeornot()
        {
            int num = value.Next(0, 2);


            if (num == 1)
            
            {
                parttime = true;
                Console.WriteLine("Employee is part time");
                partsalary = parttimerate * hour;
                Console.WriteLine("part time wage is {0}", partsalary);

            }
            else
            {
                parttime = false;
                Console.WriteLine(" parttime Employee is absent");

            }
        }





    }
}


    






