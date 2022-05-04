using System;
namespace emp_wage1
{
    public class empcal
    {
        public void checkingpresentORAbsent()
        {
            Random value = new Random();

            int empCheck = value.Next(0, 2);
            if (empCheck == 1)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        
        
    }
}

    

    
       

    