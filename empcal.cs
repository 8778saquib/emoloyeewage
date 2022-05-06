using System;
namespace emp_wage1
{
    public class empcal
    {
        int monthswage;
        int monthswagepart;
        int workingday = 20;
        int hour = 8;
        int hours;
        int parthour = 4;
        int rateperhour = 20;
        int salary;
        int parttimerate = 8;
        int partsalary;
        bool present;
        bool parttime;
        int totalemphrs = 0;
        int totalworkingday = 0;
        int totalempwage;
        Random value = new Random();

        //***********employee present or not**********



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


        //*******wage calculation of full time*********


        public void caldailywage()
        {

            if (present)
            {
                salary = hour * rateperhour;
                Console.WriteLine("daily wage is {0}", salary);
            }
        }

        //*******part time or not********


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

        //**********monthly wage of full time and part time*********


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
        //**********TotaoWorkingDaysOrHoursReached********
        public void totaoWorkingDaysOrHoursReached()
        {
            while(totalemphrs<100 && totalworkingday<20)
            {
                totalworkingday++;
                    int num4 = value.Next(0, 2);
                switch(num4)
                {
                    case 0:
                        hours = 8;
                        break;
                    case 1:
                        hours = 4;
                        break;
                    default:
                        hours = 0;
                        break;
                }
                totalemphrs = totalemphrs + hours;
            }
            totalempwage = totalemphrs + rateperhour;
            Console.WriteLine("wage till a total working hours or days is reached is{0}", totalempwage);
        }


    }

}




