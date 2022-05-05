using System;
namespace emp_wage1
{
    public class empcal
    {
        int monthswage;
        int monthswagepart;
        int workingday = 20;
        int hour = 8;
        int parthour = 4;
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
                partsalary = parttimerate * parthour;
                Console.WriteLine("part time wage is {0}", partsalary);

            }
            else
            {
                parttime = false;
                Console.WriteLine(" parttime Employee is absent");

            }
        }
        //************Using switch statement****************
        public void usingswitch()
        {
            int num1 = value.Next(0, 2);
            switch (num1)
            {
                case 1:

                

                    Console.WriteLine(" full timeEmployee is present");
                    salary = hour * rateperhour;
                    Console.WriteLine("daily wage is {0}", salary);
                    break;

                case 0:

                    Console.WriteLine("Employee is part time");
                    partsalary = parttimerate * parthour;
                    Console.WriteLine("part time wage is {0}", partsalary);

                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    break;
            }
        }
        public void monthwage()
        {
            int num2 = value.Next(0, 2);
            switch (num2)
            {
                case 1:

                monthswage = hour * rateperhour * workingday;
                Console.WriteLine("mothly  wage of full time employee is {0}", monthswage);
                    break;
                case 0:
                    monthswagepart = parttimerate * parthour * workingday;
                    Console.WriteLine("mothly  wage of part time employee is {0}", monthswagepart);
                    break;
                default:
                    Console.WriteLine(" Employee is Absent in this months");
                    break;

            }


        }

    }

}




