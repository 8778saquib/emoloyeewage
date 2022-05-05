using System;

namespace emp_wage1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to employee wage camputation");
            empcal ans = new empcal();
            ans.checkingpresentORAbsent();
            ans.caldailywage();
            ans.parttimeornot();
            ans.usingswitch();
            ans.monthwage();
        }
    }
}
